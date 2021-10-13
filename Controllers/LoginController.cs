using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ActivityManagement.Controllers
{
    class LoginController
    {
        public LoginController() {}
        private string Email { get; set; }
        private string Password { get; set; }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
        public void Login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
                    throw new Exception("Email or password is empty");

                MessageBox.Show($"Email: {Email}. Password: {Password}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
