using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PrjModule22._2.Misc;

namespace PrjModule22._2
{
    public partial class AuthForm : Form
    {
        private const string FileName = @"Users.txt";
        public static string UserName;
        public static UserRole Role;
        private static string _userPassword;
        private static bool _registration = true;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void RegLogButton_Click(object sender, EventArgs e)
        {
            regLogButton.Text = !_registration ? @"Login" : @"Registration";
            confirmButton.Text = !_registration ? @"Registration" : @"Login";
            formLabel.Text = !_registration ? @"Registration" : @"Login";
            _registration = !_registration;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            UserName = userNameTextBox.Text;
            _userPassword = passwordNameTextBox.Text;

            if (_registration)
            {
                if (CheckUserExistence() == null)
                {
                    var user = new User {Name = UserName, Password = _userPassword, Role = UserRole.User};
                    File.AppendAllLines(FileName, new List<string> {JsonConvert.SerializeObject(user)});
                    Role = user.Role;

                    using Form form = new NewsForm();
                    Hide();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(@"There is already this user");
                }
            }
            else
            {
                var user = CheckUserExistence();
                if (user != null)
                {
                    using Form form = new NewsForm();
                    UserName = user.Name;
                    Role = user.Role;

                    Hide();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Wrong Name or password");
                }
            }
        }

        private static User CheckUserExistence()
        {
            if (!File.Exists(FileName)) File.Create(FileName);

            return File.ReadAllLines(FileName)
                .Select(JsonConvert.DeserializeObject<User>).ToList()
                .Find(u => u.Name == UserName && u.Password == _userPassword);
        }
    }
}