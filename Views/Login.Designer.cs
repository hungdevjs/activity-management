
namespace ActivityManagement.Views
{
    partial class Login
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
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.ManagerCheckBox = new System.Windows.Forms.CheckBox();
            this.TeacherCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(222, 229);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(359, 23);
            this.EmailInput.TabIndex = 0;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(222, 213);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(222, 255);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(222, 271);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(359, 23);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // ManagerCheckBox
            // 
            this.ManagerCheckBox.AutoSize = true;
            this.ManagerCheckBox.Location = new System.Drawing.Point(306, 300);
            this.ManagerCheckBox.Name = "ManagerCheckBox";
            this.ManagerCheckBox.Size = new System.Drawing.Size(73, 19);
            this.ManagerCheckBox.TabIndex = 5;
            this.ManagerCheckBox.Text = "Manager";
            this.ManagerCheckBox.UseVisualStyleBackColor = true;
            // 
            // TeacherCheckBox
            // 
            this.TeacherCheckBox.AutoSize = true;
            this.TeacherCheckBox.Location = new System.Drawing.Point(428, 300);
            this.TeacherCheckBox.Name = "TeacherCheckBox";
            this.TeacherCheckBox.Size = new System.Drawing.Size(66, 19);
            this.TeacherCheckBox.TabIndex = 6;
            this.TeacherCheckBox.Text = "Teacher";
            this.TeacherCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(222, 325);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(359, 25);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.UseWaitCursor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TeacherCheckBox);
            this.Controls.Add(this.ManagerCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailInput);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.CheckBox ManagerCheckBox;
        private System.Windows.Forms.CheckBox TeacherCheckBox;
        private System.Windows.Forms.Button LoginButton;
    }
}