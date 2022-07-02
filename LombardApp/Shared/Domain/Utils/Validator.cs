using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LombardApp.Shared.Domain.Utils
{
    public static class Validator
    {
        public static bool ValidateEmail(string email) => new Regex(@"^(.+)@(.+)\.(.+)").IsMatch(email);

        public static bool ValidatePassword(string password) => password.Length > 5 && password.Any(Char.IsLower) && password.Any(Char.IsUpper) && password.Any(Char.IsNumber);
    }
}
