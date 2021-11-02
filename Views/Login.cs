using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActivityManagement.Controllers;
using ActivityManagement.Helpers;

namespace ActivityManagement.Views
{
    public partial class Login : Form
    {
        private LoginController controller;
        public Login()
        {
            InitializeComponent();
            controller = new LoginController();
            PasswordInput.PasswordChar = '*';
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            controller.SetEmail(EmailInput.Text);
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            controller.SetPassword(PasswordInput.Text);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            controller.Login();
        }

        private void TeacherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TeacherCheckBox.Checked)
            {
                controller.SetRole(Constants.TEACHER);
                ManagerCheckBox.Checked = false;
                return;
            }

            controller.SetRole(null);
        }

        private void ManagerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ManagerCheckBox.Checked)
            {
                controller.SetRole(Constants.MANAGER);
                TeacherCheckBox.Checked = false;
                return;
            }

            controller.SetRole(null);
        }
    }
}
