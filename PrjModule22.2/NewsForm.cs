using PrjModule22._2.Misc;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrjModule22._2
{
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
        }

        private const int VerticalPosStart = 66;

        private readonly List<NewsHolder> _tmpNews = new List<NewsHolder>()
            {
                new()
                {
                    Sender = new User() {Name = "Andrew"},
                    Comments = new List<Comment>()
                    {
                        new()
                        {
                            Message = "Comment1",
                            SubComments = new List<Comment>()
                            {
                                new()
                                {
                                    Message = "Comment11"
                                },
                                new()
                                {
                                    Message = "Comment12"
                                }
                            }
                        },
                        new()
                        {
                            Message = "Comment2",
                            SubComments = new List<Comment>()
                            {
                                new()
                                {
                                    Message = "Comment21"
                                },
                                new()
                                {
                                    Message = "Comment22"
                                }
                            }
                        }
                    },
                    Text = "This is news"
                },
                new()
                {
                    Sender = new User() {Name = "Andrew"},
                    Comments = new List<Comment>()
                    {
                        new()
                        {
                            Message = "Comment1",
                            SubComments = new List<Comment>()
                            {
                                new()
                                {
                                    Message = "Comment11"
                                },
                                new()
                                {
                                    Message = "Comment12"
                                }
                            }
                        },
                        new()
                        {
                            Message = "Comment2",
                            SubComments = new List<Comment>()
                            {
                                new()
                                {
                                    Message = "Comment21"
                                },
                                new()
                                {
                                    Message = "Comment22"
                                }
                            }
                        }
                    },
                    Text = "This is news"
                },
                new()
                {
                    Sender = new User() {Name = "Andrew"},
                    Comments = new List<Comment>()
                    {
                        new()
                        {
                            Message = "Comment1",
                            SubComments = new List<Comment>()
                            {
                                new()
                                {
                                    Message = "Comment11"
                                },
                                new()
                                {
                                    Message = "Comment12"
                                }
                            }
                        },
                        new()
                        {
                            Message = "Comment2",
                            SubComments = new List<Comment>()
                            {
                                new()
                                {
                                    Message = "Comment21"
                                },
                                new()
                                {
                                    Message = "Comment22"
                                }
                            }
                        }
                    },
                    Text = "This is news"
                }
            };
        
        private static int _verticalPos= VerticalPosStart;
        private void button3_Click(object sender, EventArgs e)
        {
            IterateThroughNews();
        }

        private void IterateThroughNews()
        {
            Controls.Clear();
            var panelLocation = 12;
            foreach (var news in _tmpNews)
            {
                SuspendLayout();

                //Create Panels
                var panel = new Panel()
                {
                    AutoScroll = true,
                    Size = new System.Drawing.Size(500, 100),
                    Location = new System.Drawing.Point(12, panelLocation),
                    TabIndex = 0
                };
                panel.SuspendLayout();
                panelLocation += 12 + panel.Height;

                var rtb = new RichTextBox
                {
                    Location = new System.Drawing.Point(12, 10),
                    Size = new System.Drawing.Size(461, 50),
                    TabIndex = 0,
                    Text = news.Text + "\n    made by " + news.Sender.Name
                };
                panel.Controls.Add(rtb);

                IterateThroughComments(panel, news.Comments, 12);
                _verticalPos = VerticalPosStart;

                ResumeLayout();
                panel.ResumeLayout();
                Controls.Add(panel);
            }
        }
        private void IterateThroughComments(Control panel, IList<Comment> commentList, int startPos)
        {

            for (var i = 0; i < commentList.Count; i++)
            {
                var commentLine = new TextBox()
                {
                    Location = new System.Drawing.Point(startPos, _verticalPos),
                    Size = new System.Drawing.Size(374 - startPos, 23),
                    TabIndex = 1,
                    Text = commentList[i].Message
                };

                var removeComment = new Button
                {
                    FlatStyle = System.Windows.Forms.FlatStyle.System,
                    Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point),
                    ImageAlign = System.Drawing.ContentAlignment.TopRight,
                    Location = new System.Drawing.Point(423, _verticalPos),
                    Size = new System.Drawing.Size(25, 23),
                    TabIndex = 1,
                    Text = @"x",
                    TextAlign = System.Drawing.ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = true
                };
                removeComment.Click += (sender, args) =>
                {
                    commentList.Remove(commentList[i-1]);
                    IterateThroughNews();
                };

                var addComment = new Button
                {
                    FlatStyle = System.Windows.Forms.FlatStyle.System,
                    Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point),
                    ImageAlign = System.Drawing.ContentAlignment.TopRight,
                    Location = new System.Drawing.Point(392, _verticalPos),
                    Size = new System.Drawing.Size(25, 23),
                    TabIndex = 1,
                    Text = @"+",
                    TextAlign = System.Drawing.ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = true
                };
                addComment.Click += (sender, args) =>
                {
                    commentLine.Text += @" 1";
                    commentList[i].Message += " 1";
                };

                _verticalPos += 29;

                panel.Controls.Add(commentLine);
                panel.Controls.Add(addComment);
                panel.Controls.Add(removeComment);

                if (commentList[i].SubComments.Count > 0)
                {
                    IterateThroughComments(panel, commentList[i].SubComments, startPos + 5);
                }
            }
            foreach (var comment in commentList)
            {
               
            }
        }
    }
}

