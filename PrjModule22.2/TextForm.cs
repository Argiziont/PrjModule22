using System;
using System.Windows.Forms;

namespace PrjModule22._2
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
            richTextBox1.Clear();
        }

        public new string Text { get; private set; }
        public bool OkResult { get; private set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Text = richTextBox1.Text;
            OkResult = true;
            Close();
        }
    }
}