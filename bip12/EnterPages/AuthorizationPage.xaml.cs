using bip12.Services;
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

namespace bip12.EnterPages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        private readonly UserService _userService = new();
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var users = await _userService.GetUsersAsync();
            foreach (var user in users)
            {
                if (user.Login == LoginTextBox.Text && user.Password == PasswordBox.Password)
                {
                    MainBip12 mainBip12 = new();
                    MainWindow mainWindow = new();
                    mainWindow.Hide();
                    mainBip12.Show();
                }
                else
                {
                    MessageBox.Show("Неверно указан логин или пароль");
                }
            }
        }
    }
}
