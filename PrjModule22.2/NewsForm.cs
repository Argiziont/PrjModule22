using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PrjModule22._2.Misc;
using PrjModule22._2.News_Logic;

namespace PrjModule22._2
{
    public partial class NewsForm : Form
    {
        private const int VerticalPosStart = 66;

        private static int _verticalPos = VerticalPosStart;

        private readonly List<Panel> _panels = new();
        private readonly UdpClient _udpClient;

        private List<NewsHolder> _newsList = new();

        public NewsForm()
        {
            InitializeComponent();
            AddNewsButton.Click += AddNewsButtonOnClick;
            _udpClient = new UdpClient {RemoteAddress = IPAddress.Parse("235.5.5.11")};
            _udpClient.Broadcast += UdpClientOnBroadcast;
            Task.Run(_udpClient.ReceiveMessage);

            IterateThroughNews();
        }

        private void UdpClientOnBroadcast(object sender, BroadcastEventArgs e)
        {
            _newsList = JsonConvert.DeserializeObject<List<NewsHolder>>(e.Message);
            Invoke((MethodInvoker) IterateThroughNews);
        }

        private void IterateThroughNews()
        {
            foreach (var panel in _panels) Controls.Remove(panel);

            var panelLocation = 16;
            foreach (var news in _newsList)
            {
                SuspendLayout();

                //Create Main controls
                var panel = new Panel
                {
                    AutoScroll = true,
                    Size = new Size(535, 100),
                    Location = new Point(12, panelLocation),
                    TabIndex = 0
                };
                panel.SuspendLayout();
                panelLocation += 12 + panel.Height;

                var rtb = new RichTextBox
                {
                    Location = new Point(12, 10),
                    Size = new Size(461, 50),
                    TabIndex = 0,
                    ReadOnly = true,
                    Text = news.Text + @" made by " + news.Sender.Name
                };
                var mainRemoveButton = new ButtonWithHolder
                {
                    FlatStyle = FlatStyle.System,
                    Font = new Font("Segoe UI", 15F, FontStyle.Regular,
                        GraphicsUnit.Point),
                    ImageAlign = ContentAlignment.TopRight,
                    Location = new Point(475, 10),
                    Name = "RemoveNewsButton",
                    Size = new Size(25, 23),
                    TabIndex = 1,
                    Text = @"x",
                    TextAlign = ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = true,
                    NewsHolder = news
                };


                mainRemoveButton.Click += MainRemoveButtonOnClick;

                var mainCommentButton = new ButtonWithHolder
                {
                    FlatStyle = FlatStyle.System,
                    Font = new Font("Segoe UI", 15F, FontStyle.Regular,
                        GraphicsUnit.Point),
                    ImageAlign = ContentAlignment.TopRight,
                    Location = new Point(475, 37),
                    Name = "MainCommentButton",
                    Size = new Size(25, 23),
                    TabIndex = 1,
                    Text = @"+",
                    TextAlign = ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = true,
                    SubComment = news.Comments
                };
                mainCommentButton.Click += AddCommentOnClick;

                panel.Controls.Add(rtb);
                panel.Controls.Add(mainCommentButton);
                panel.Controls.Add(mainRemoveButton);
                _panels.Add(panel);
                IterateThroughComments(panel, news.Comments, 12);
                _verticalPos = VerticalPosStart;

                ResumeLayout();
                panel.ResumeLayout();
                Controls.Add(panel);
            }
        }

        private void IterateThroughComments(Control panel, IList<Comment> commentList, int startPos)
        {
            foreach (var comment in commentList)
            {
                var commentLine = new TextBox
                {
                    Location = new Point(startPos, _verticalPos),
                    Size = new Size(374 - startPos, 23),
                    TabIndex = 1,
                    ReadOnly = true,
                    Text = comment.Message
                };

                var removeComment = new ButtonWithHolder
                {
                    FlatStyle = FlatStyle.System,
                    Font = new Font("Segoe UI", 15F, FontStyle.Regular,
                        GraphicsUnit.Point),
                    ImageAlign = ContentAlignment.TopRight,
                    Location = new Point(423, _verticalPos),
                    Size = new Size(25, 23),
                    TabIndex = 1,
                    Text = @"x",
                    TextAlign = ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = true,
                    Comment = comment,
                    SubComment = commentList
                };
                removeComment.Click += RemoveCommentOnClick;


                var addComment = new ButtonWithHolder
                {
                    FlatStyle = FlatStyle.System,
                    Font = new Font("Segoe UI", 15F, FontStyle.Regular,
                        GraphicsUnit.Point),
                    ImageAlign = ContentAlignment.TopRight,
                    Location = new Point(392, _verticalPos),
                    Size = new Size(25, 23),
                    TabIndex = 1,
                    Text = @"+",
                    TextAlign = ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = true,
                    SubComment = comment.SubComments
                };
                addComment.Click += AddCommentOnClick;

                _verticalPos += 29;

                panel.Controls.Add(commentLine);
                panel.Controls.Add(addComment);
                panel.Controls.Add(removeComment);

                if (comment.SubComments.Count > 0) IterateThroughComments(panel, comment.SubComments, startPos + 5);
            }
        }

        private void AddCommentOnClick(object sender, EventArgs e)
        {
            using var textForm = new TextForm();
            textForm.ShowDialog();
            if (!textForm.OkResult) return;
            var button = (ButtonWithHolder) sender;
            button?.SubComment.Add(new Comment
            {
                Message = textForm.Text
            });
            _udpClient.BroadcastMessage(JsonConvert.SerializeObject(_newsList));
            //IterateThroughNews();
        }

        private void MainRemoveButtonOnClick(object sender, EventArgs _)
        {
            if (AuthForm.Role != UserRole.Moderator)
            {
                MessageBox.Show(@"Your are not moderator to delete this");
                return;
            }

            var button = (ButtonWithHolder) sender;

            _newsList.Remove(button.NewsHolder);
            _udpClient.BroadcastMessage(JsonConvert.SerializeObject(_newsList));
            //IterateThroughNews();
        }

        private void RemoveCommentOnClick(object sender, EventArgs e)
        {
            if (AuthForm.Role != UserRole.Moderator)
            {
                MessageBox.Show(@"Your are not moderator to delete this");
                return;
            }

            var button = (ButtonWithHolder) sender;

            button?.SubComment.Remove(button.Comment);
            _udpClient.BroadcastMessage(JsonConvert.SerializeObject(_newsList));
            //IterateThroughNews();
        }

        private void AddNewsButtonOnClick(object sender, EventArgs e)
        {
            using var textForm = new TextForm();
            textForm.ShowDialog();
            if (!textForm.OkResult) return;
            _newsList.Add(new NewsHolder
            {
                Text = textForm.Text,
                Sender = new User
                {
                    Name = AuthForm.UserName,
                    Role = AuthForm.Role
                }
            });
            _udpClient.BroadcastMessage(JsonConvert.SerializeObject(_newsList));
            // IterateThroughNews();
        }
    }
}