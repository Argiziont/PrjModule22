
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
            this.RemoveNewsButton = new System.Windows.Forms.Button();
            this.RemoveComment = new System.Windows.Forms.Button();
            this.MainCommentButton = new System.Windows.Forms.Button();
            this.AddComment = new System.Windows.Forms.Button();
            this.CommentLine = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddNewsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.RemoveNewsButton);
            this.panel1.Controls.Add(this.RemoveComment);
            this.panel1.Controls.Add(this.MainCommentButton);
            this.panel1.Controls.Add(this.AddComment);
            this.panel1.Controls.Add(this.CommentLine);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // RemoveNewsButton
            // 
            this.RemoveNewsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveNewsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveNewsButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemoveNewsButton.Location = new System.Drawing.Point(475, 10);
            this.RemoveNewsButton.Name = "RemoveNewsButton";
            this.RemoveNewsButton.Size = new System.Drawing.Size(25, 23);
            this.RemoveNewsButton.TabIndex = 1;
            this.RemoveNewsButton.Text = "x";
            this.RemoveNewsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveNewsButton.UseVisualStyleBackColor = true;
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
            // MainCommentButton
            // 
            this.MainCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainCommentButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainCommentButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MainCommentButton.Location = new System.Drawing.Point(475, 37);
            this.MainCommentButton.Name = "MainCommentButton";
            this.MainCommentButton.Size = new System.Drawing.Size(25, 23);
            this.MainCommentButton.TabIndex = 1;
            this.MainCommentButton.Text = "+";
            this.MainCommentButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainCommentButton.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewsButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddNewsButton
            // 
            this.AddNewsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.AddNewsButton.Name = "AddNewsButton";
            this.AddNewsButton.Size = new System.Drawing.Size(92, 20);
            this.AddNewsButton.Text = "Manage news";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newToolStripMenuItem.Text = "&Add new news";
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewsForm";
            this.Text = "News Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveComment;
        private System.Windows.Forms.Button AddComment;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox CommentLine;
        private System.Windows.Forms.Button MainCommentButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddNewsButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button RemoveNewsButton;
    }
}

