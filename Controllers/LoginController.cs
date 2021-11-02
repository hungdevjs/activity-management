using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using ActivityManagement.Data;
using ActivityManagement.Helpers;

namespace ActivityManagement.Controllers
{
    class LoginController
    {
        private string Email { get; set; }
        private string Password { get; set; }
        private string Role { get; set; }
        private ApplicationDbContext context { get; set; }
        private GlobalState state { get; set; }

        public LoginController() 
        {
            context = new ApplicationDbContext();
            state = GlobalState.GetInstance();
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
        public void SetRole(string role)
        {
            Role = role;
        }
        public void Login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Role))
                    throw new Exception("Email or password or role is empty");

                if (Role == Constants.TEACHER)
                {
                    var user = context.Teachers.FirstOrDefault(i => i.Email == Email);
                    if (user == default) throw new Exception(Constants.BAD_CREDENTIAL);

                    var validPassword = BCrypt.Net.BCrypt.Verify(Password, user.Password);
                    if (!validPassword) throw new Exception(Constants.BAD_CREDENTIAL);

                    state.LogIn(user.Id, user.Email, Role);
                }

                if (Role == Constants.MANAGER)
                {
                    var user = context.Managers.FirstOrDefault(i => i.Email == Email);
                    if (user == default) throw new Exception(Constants.BAD_CREDENTIAL);

                    var validPassword = BCrypt.Net.BCrypt.Verify(Password, user.Password);
                    if (!validPassword) throw new Exception(Constants.BAD_CREDENTIAL);

                    state.LogIn(user.Id, user.Email, Role);
                }

                MessageBox.Show("Log in successfully!"); // redirect to home page
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
