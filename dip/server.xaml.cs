using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;

namespace dip
{
    /// <summary>
    /// Логика взаимодействия для server.xaml
    /// </summary>
    public partial class server : Page
    {
        public server()
        {
            InitializeComponent();

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            string Path = @"C:\Users\user\source\repos\dip\DATA.TXT";
            Random random = new Random();
            int key = random.Next(0, 100000);
            // FileInfo file = new FileInfo(Path);
            string kayin = Convert.ToString(key);
            File.WriteAllText(Path, kayin);
            XmlDocument DOX = new XmlDocument();
            DOX.Load("XMLFile1.xml");
            XmlElement xRoot = DOX.DocumentElement;
            XmlElement kays = DOX.CreateElement("data");
            XmlElement ipElem = DOX.CreateElement("ip");
            XmlText SAD = DOX.CreateTextNode(kayin);
            kays.AppendChild(SAD);
            xRoot.AppendChild(kays) ;
            DOX.Save("XMLFile1.xml");
        }
    }
}
