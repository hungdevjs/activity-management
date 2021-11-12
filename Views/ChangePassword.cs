using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActivityManagement.Controllers;

namespace ActivityManagement.Views
{
    public partial class ChangePassword : Form
    {
        private ChangePasswordController controller;
        public ChangePassword()
        {
            InitializeComponent();
            controller = new ChangePasswordController();
            OldPasswordInput.PasswordChar = '*';
            NewPasswordInput.PasswordChar = '*';
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            Hide();
        }

        private void OldPasswordInput_TextChanged(object sender, EventArgs e)
        {
            controller.SetOldPassword(OldPasswordInput.Text);
        }

        private void NewPasswordInput_TextChanged(object sender, EventArgs e)
        {
            controller.SetNewPassword(NewPasswordInput.Text);
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                controller.ChangePassword();
                MessageBox.Show("Change password successfully");
                var home = new Home();
                home.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
