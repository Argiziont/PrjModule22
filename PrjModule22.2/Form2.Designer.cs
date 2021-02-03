
namespace PrjModule22._2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regLogButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordNameTextBox = new System.Windows.Forms.TextBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regLogButton
            // 
            this.regLogButton.Location = new System.Drawing.Point(12, 341);
            this.regLogButton.Name = "regLogButton";
            this.regLogButton.Size = new System.Drawing.Size(87, 23);
            this.regLogButton.TabIndex = 0;
            this.regLogButton.Text = "Registration";
            this.regLogButton.UseVisualStyleBackColor = true;
            this.regLogButton.Click += new System.EventHandler(this.regLogButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(12, 117);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(281, 23);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordNameTextBox
            // 
            this.passwordNameTextBox.Location = new System.Drawing.Point(12, 204);
            this.passwordNameTextBox.Name = "passwordNameTextBox";
            this.passwordNameTextBox.Size = new System.Drawing.Size(281, 23);
            this.passwordNameTextBox.TabIndex = 1;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formLabel.Location = new System.Drawing.Point(12, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(199, 46);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Location = new System.Drawing.Point(101, 259);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(128, 39);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Registration";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.passwordNameTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.regLogButton);
            this.Name = "Form2";
            this.Text = "SingUP Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regLogButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordNameTextBox;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmButton;
    }
}