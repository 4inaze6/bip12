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

namespace bip12.MainBip12Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfileLeftMenuPage.xaml
    /// </summary>
    public partial class ProfileLeftMenuPage : Page
    {
        private MainBip12 _mainBip12;
        public ProfileLeftMenuPage(MainBip12 mainBip12)
        {
            InitializeComponent();

            _mainBip12 = mainBip12;
            GoBackButton.IsEnabled = false;
        }

        private void AboutMeButton_Click(object sender, RoutedEventArgs e)
        {
            _mainBip12.MainFrame.Navigate(new AboutMePage());
        }

        private void MyBooksButton_Click(object sender, RoutedEventArgs e)
        {
            _mainBip12.MainFrame.Navigate(new MyBooksPage());
        }

        private void ReadingDiaryButton_Click(object sender, RoutedEventArgs e)
        {
            _mainBip12.MainFrame.Navigate(new ReadingDiaryPage());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (_mainBip12.MainFrame.Content is not HelloPage)
            {
                _mainBip12.MainFrame.GoBack();
                GoBackButton.IsEnabled = true;
            }
            else
                GoBackButton.IsEnabled = false;
        }
    }
}
