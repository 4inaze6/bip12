using bip12.Models;
using bip12.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace bip12.EnterPages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private readonly UserService _userService = new();
        private User _user;
        public RegistrationPage(User? user = null)
        {
            InitializeComponent();

            _user = user ?? new();
            DataContext = _user;
        }

        private async void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new();
            bool loginContain = false;
            var users = await _userService?.GetUsersAsync();

            foreach (var user in users)
            {
                if (user.Login == LoginTextBox.Text)
                {
                    errors.AppendLine("Такой пользователь уже существует");
                }
            }
            if (PasswordBox.Password != ConfirmationPasswordBox.Password)
                errors.AppendLine("Поля пароль и подтверждение паролей не совпадают");
            if (LoginTextBox.Text == "" || PasswordBox.Password == "" || ConfirmationPasswordBox.Password == "")
                errors.AppendLine("Все поля должны быть заполнены");
            if (!Regex.IsMatch(PasswordBox.Password, "^(?=.*[A-ZА-Я])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-zа-я]).{8,}$"))
                errors.AppendLine("Пароль не соответствует условиям(длина пароля >8 символов, пароль должен содержать заглавные и прописные буквы, а также спец символы(!, @, #, $, %, &))");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                try 
                { 
                    _user.Password = PasswordBox.Password;
                    await _userService.AddUserAsync(_user);
                    MessageBox.Show("Вы успешно зарегестрированы!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainBip12 mainBip12 = new();
                    MainWindow mainWindow = new();
                    mainWindow.Hide();
                    mainBip12.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }


        }
    }
}
