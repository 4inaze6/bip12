using bip12.MainBip12Pages;
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
using System.Windows.Shapes;

namespace bip12
{
    /// <summary>
    /// Логика взаимодействия для MainBip12.xaml
    /// </summary>
    public partial class MainBip12 : Window
    {
        public MainBip12()
        {
            InitializeComponent();

            ProfileLeftMenuPage profileLeftMenuPage = new(this);
            LeftMenu.Navigate(profileLeftMenuPage);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HelloPage());
        }
    }
}
