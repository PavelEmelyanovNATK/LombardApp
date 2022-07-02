using LombardApp.Shared.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LombardApp.Modules.Auth
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            if(AuthManager.IsAuthed(TextBoxLogin.Text, TextBoxPassword.Password))
            {
                MessageBox.Show("Успешная авторизация!");
            } 
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            TextBoxLogin.Text = null;
            TextBoxPassword.Password = null;
        }
    }
}
