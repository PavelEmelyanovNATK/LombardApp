using LombardApp.Modules.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LombardApp.Shared.Domain.Services.NavProvider
{
    public static class NavProvider
    {
        private static Frame _frame = null;

        public static void Setup(Frame frame) => _frame = frame;

        public static void NavigateToAuth() => _frame.Content = new AuthPage();
    }
}
