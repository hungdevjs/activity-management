using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

using ActivityManagement.Data;
using ActivityManagement.Helpers;

namespace ActivityManagement.Controllers
{
    class ChangePasswordController
    {
        private string OldPassword{ get; set; }
        private string NewPassword { get; set; }
        private ApplicationDbContext context { get; set; }
        private GlobalState state { get; set; }

        public ChangePasswordController()
        {
            context = new ApplicationDbContext();
            state = GlobalState.GetInstance();
        }

        public void SetOldPassword(string oldPassword)
        {
            this.OldPassword = oldPassword;
        }

        public void SetNewPassword(string newPassword)
        {
            this.NewPassword = newPassword;
        }

        public void ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(OldPassword) || string.IsNullOrWhiteSpace(NewPassword))
                throw new Exception("Please fill in passwords");

            if (!Utils.PasswordStrengthValidator(NewPassword)) throw new Exception("Password is weak");
        }

        public void ChangePassword()
        {
            ValidatePassword();
            var userId = state.CurrentUserId;
            var role = state.CurrentUserRole;
            var isTeacher = role == Constants.TEACHER;
            var isManager = role == Constants.MANAGER;

            if (isTeacher)
            {
                var teacher = context.Teachers.FirstOrDefault(i => i.Id == userId);
                if (teacher == default) throw new Exception("Bad request");

                var validPassword = BCrypt.Net.BCrypt.Verify(OldPassword, teacher.Password);
                if (!validPassword) throw new Exception(Constants.BAD_CREDENTIAL);

                var salt = BCrypt.Net.BCrypt.GenerateSalt(6);
                var password = BCrypt.Net.BCrypt.HashPassword(NewPassword, salt);

                teacher.Password = password;
                context.SaveChanges();
            }

            if (isManager)
            {
                var manager = context.Managers.FirstOrDefault(i => i.Id == userId);
                if (manager == default) throw new Exception("Bad request");

                var validPassword = BCrypt.Net.BCrypt.Verify(NewPassword, manager.Password);
                if (!validPassword) throw new Exception(Constants.BAD_CREDENTIAL);

                var salt = BCrypt.Net.BCrypt.GenerateSalt(6);
                var password = BCrypt.Net.BCrypt.HashPassword(NewPassword, salt);

                manager.Password = password;
                context.SaveChanges();
            }
        }
    }
}
