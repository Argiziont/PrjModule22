using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using PrjModule22._2.Misc;

namespace PrjModule22._2
{
    public partial class Form2 : Form
    {
        private static string _userName;
        private static string _userPassword;
        private static bool _registration=true;
        private static string _fileName = @"Users.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void regLogButton_Click(object sender, EventArgs e)
        {
            regLogButton.Text = !_registration ? @"Registration" : @"Login";
            confirmButton.Text = !_registration ? @"Registration" : @"Login";
            formLabel.Text = !_registration ? @"Registration" : @"Login";
            _registration = !_registration;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            _userName = userNameTextBox.Text;
            _userPassword = passwordNameTextBox.Text;
            
            if (_registration)
            {
                if (!CheckUserExistence())
                {
                    var user = new User() {Name = _userName, Password = _userPassword};
                    File.AppendAllLines(_fileName, new List<string> {JsonConvert.SerializeObject(user)});

                    using Form form = new Form1();
                    Hide();
                    form.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show(@"There is already this user");

            }
            else
            {
                if (CheckUserExistence())
                {

                    using Form form = new Form1();
                    Hide();
                    form.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show(@"Wrong Name or password");
            }
        }

        private static bool CheckUserExistence() => (File.ReadAllLines(_fileName).Select(JsonConvert.DeserializeObject<User>).ToList().Find(u=>u.Name==_userName&& u.Password==_userPassword) !=null);
    }
}
