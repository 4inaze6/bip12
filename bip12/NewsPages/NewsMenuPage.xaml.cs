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

namespace bip12.NewsPages
{
    /// <summary>
    /// Логика взаимодействия для NewsMenuPage.xaml
    /// </summary>
    public partial class NewsMenuPage : Page
    {
        private readonly MainBip12 _mainBip12;
        public NewsMenuPage(MainBip12 mainBip12)
        {
            InitializeComponent();
            _mainBip12 = mainBip12;
        }

        private void AboutMeButton_Click(object sender, RoutedEventArgs e)
        {
            _mainBip12.MainFrame.Navigate(new NewsPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _mainBip12.MainFrame.Navigate(new NewsPage());
        }
    }
}
