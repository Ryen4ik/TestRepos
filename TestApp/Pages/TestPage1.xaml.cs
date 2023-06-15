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
using TestApp.Classes;

namespace TestApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestPage1.xaml
    /// </summary>
    public partial class TestPage1 : Page
    {
        public TestPage1()
        {
            InitializeComponent();
        }

        private void buttonTest1_Click(object sender, RoutedEventArgs e)
        {
            NavigationManager.MainFrame.Navigate(new TestPage2());
        }
    }
}
