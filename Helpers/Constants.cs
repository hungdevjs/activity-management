using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityManagement.Helpers
{
    public static class Constants
    {
        public static string ConnectionString = "Server=.\\sqlexpress;Database=ActivityManagement;User ID=sa;Password=Asdfgh1@3;Trusted_Connection=true";
        public static string DefaultPassword = "Asdfgh1@3";
        public static int DefaultStudentPoint = 60;
        public static string APPROVED = "Approved";
        public static string PENDING = "Pending";
        public static string CANCELLED = "Cancelled";
        public static string TEACHER = "Teacher";
        public static string MANAGER = "Manager";
        public static string STUDENT = "Student";

        // errors
        public static string BAD_CREDENTIAL = "Bad credential";
    }
}
