
namespace ActivityManagement.Views
{
    partial class Home
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.StudentBtn = new System.Windows.Forms.Button();
            this.TeacherBtn = new System.Windows.Forms.Button();
            this.ActivityBtn = new System.Windows.Forms.Button();
            this.ActivityTypeBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.Location = new System.Drawing.Point(27, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(122, 30);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User email";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(697, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Log out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // StudentBtn
            // 
            this.StudentBtn.Location = new System.Drawing.Point(234, 107);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(316, 38);
            this.StudentBtn.TabIndex = 2;
            this.StudentBtn.Text = "Students";
            this.StudentBtn.UseVisualStyleBackColor = true;
            // 
            // TeacherBtn
            // 
            this.TeacherBtn.Location = new System.Drawing.Point(234, 160);
            this.TeacherBtn.Name = "TeacherBtn";
            this.TeacherBtn.Size = new System.Drawing.Size(316, 38);
            this.TeacherBtn.TabIndex = 3;
            this.TeacherBtn.Text = "Teachers";
            this.TeacherBtn.UseVisualStyleBackColor = true;
            // 
            // ActivityBtn
            // 
            this.ActivityBtn.Location = new System.Drawing.Point(234, 217);
            this.ActivityBtn.Name = "ActivityBtn";
            this.ActivityBtn.Size = new System.Drawing.Size(316, 38);
            this.ActivityBtn.TabIndex = 5;
            this.ActivityBtn.Text = "Activities";
            this.ActivityBtn.UseVisualStyleBackColor = true;
            // 
            // ActivityTypeBtn
            // 
            this.ActivityTypeBtn.Location = new System.Drawing.Point(234, 276);
            this.ActivityTypeBtn.Name = "ActivityTypeBtn";
            this.ActivityTypeBtn.Size = new System.Drawing.Size(316, 38);
            this.ActivityTypeBtn.TabIndex = 6;
            this.ActivityTypeBtn.Text = "Activity types";
            this.ActivityTypeBtn.UseVisualStyleBackColor = true;
            // 
            // SettingBtn
            // 
            this.SettingBtn.Location = new System.Drawing.Point(234, 338);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(316, 38);
            this.SettingBtn.TabIndex = 7;
            this.SettingBtn.Text = "Settings";
            this.SettingBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(234, 396);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(316, 38);
            this.ChangePasswordBtn.TabIndex = 8;
            this.ChangePasswordBtn.Text = "Change password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.ActivityTypeBtn);
            this.Controls.Add(this.ActivityBtn);
            this.Controls.Add(this.TeacherBtn);
            this.Controls.Add(this.StudentBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.UserLabel);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Button TeacherBtn;
        private System.Windows.Forms.Button ActivityBtn;
        private System.Windows.Forms.Button ActivityTypeBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button ChangePasswordBtn;
    }
}