using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityManagement.Helpers
{
    public class GlobalState
    {
        private GlobalState() { }

        private static GlobalState instance;

        private static int CurrentUserId { get; set; }
        private static string CurrentUserEmail { get; set; }
        private static string CurrentUserRole { get; set; }
        public static GlobalState GetInstance()
        {
            if (instance == null)
            {
                instance = new GlobalState();
            }
            return instance;
        }

        public void LogIn(int currentUserId, string currentUserEmail, string currentUserRole)
        {
            CurrentUserId = currentUserId;
            CurrentUserEmail = currentUserEmail;
            CurrentUserRole = currentUserRole;
        }

        public void LogOut()
        {
            CurrentUserId = 0;
            CurrentUserEmail = null;
            CurrentUserRole = null;
        }

        public bool IsAuth()
        {
            return CurrentUserId != 0;
        }

        public bool IsTeacher()
        {
            return CurrentUserRole == Constants.TEACHER;
        }

        public bool IsManager()
        {
            return CurrentUserRole == Constants.MANAGER;
        }
    }
}
