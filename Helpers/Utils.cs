using System.IO;
using System.Text.RegularExpressions;

namespace ActivityManagement.Helpers
{
    public static class Utils
    {
        public static bool PasswordStrengthValidator(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            return hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
        }
    }
}
