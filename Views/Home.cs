using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ActivityManagement.Helpers;

namespace ActivityManagement.Views
{
    public partial class Home : Form
    {
        private GlobalState state { get; set; }
        public Home()
        {
            InitializeComponent();
            state = GlobalState.GetInstance();
            UserLabel.Text = state.CurrentUserEmail.ToString();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            state.LogOut();
            var login = new Login();
            login.Show();
            Hide();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            var changePassword = new ChangePassword();
            changePassword.Show();
            Hide();
        }
    }
}
