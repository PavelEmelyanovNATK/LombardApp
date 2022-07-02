using LombardApp.Shared.Domain.Services.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Shared.Domain.Utils
{
    public static class AuthManager
    {
        public static bool IsAuthed(string login, string password)
        {
            using (var dao = new LombardEntities())
            {
                return dao.Employees.Any(e => e.Login == login && e.Password == password);
            }
        }
    }
}
