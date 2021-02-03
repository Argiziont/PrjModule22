
namespace PrjModule22._2
{
    partial class NewsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveComment = new System.Windows.Forms.Button();
            this.AddComment = new System.Windows.Forms.Button();
            this.CommentLine = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.RemoveComment);
            this.panel1.Controls.Add(this.AddComment);
            this.panel1.Controls.Add(this.CommentLine);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // RemoveComment
            // 
            this.RemoveComment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveComment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveComment.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemoveComment.Location = new System.Drawing.Point(423, 66);
            this.RemoveComment.Name = "RemoveComment";
            this.RemoveComment.Size = new System.Drawing.Size(25, 23);
            this.RemoveComment.TabIndex = 1;
            this.RemoveComment.Text = "x";
            this.RemoveComment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveComment.UseVisualStyleBackColor = true;
            // 
            // AddComment
            // 
            this.AddComment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddComment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddComment.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddComment.Location = new System.Drawing.Point(392, 66);
            this.AddComment.Name = "AddComment";
            this.AddComment.Size = new System.Drawing.Size(25, 23);
            this.AddComment.TabIndex = 1;
            this.AddComment.Text = "+";
            this.AddComment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddComment.UseVisualStyleBackColor = true;
            // 
            // CommentLine
            // 
            this.CommentLine.Location = new System.Drawing.Point(12, 66);
            this.CommentLine.Name = "CommentLine";
            this.CommentLine.Size = new System.Drawing.Size(374, 23);
            this.CommentLine.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 50);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Name = "NewsForm";
            this.Text = "News Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveComment;
        private System.Windows.Forms.Button AddComment;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox CommentLine;
        private System.Windows.Forms.Button button3;
    }
}

