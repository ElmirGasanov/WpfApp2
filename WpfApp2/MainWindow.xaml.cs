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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string imgsource1 = @"\\sysprofile.adm.vvsu.ru\STUDENTPROFILES$\Elmir\Downloads\24152197af38deb718eb730992d441d0.jpg";
        private string imgsource2 = @"\\sysprofile.adm.vvsu.ru\STUDENTPROFILES$\Elmir\Downloads\ltym.jpg";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение закрылось");
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsource1));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsource2));
        }
    }
}
