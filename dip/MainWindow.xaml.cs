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

namespace dip
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Page> list; //лист страниц 
        int index; // индекс страницы
        public MainWindow()
        {
            InitializeComponent();
            this.list = new List<Page>();
            index = 0;
            list.Add(new server());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Myframe.Content = new server();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Myframe.Content = new DESCTOP();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }
    }
}
