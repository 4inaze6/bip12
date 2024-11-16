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
    /// Логика взаимодействия для MainEnterPage.xaml
    /// </summary>
    public partial class MainEnterPage : Page
    {
        private MainWindow _mainWindow;
        public MainEnterPage(MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.EnterFrame.Navigate(new RegistrationPage());
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.EnterFrame.Navigate(new AuthorizationPage());
        }
    }
}
