using HandyControl.Controls;
using HandyControl.Data;
using Microsoft.Win32;
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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using MessageBox = HandyControl.Controls.MessageBox;


namespace dip
{
    /// <summary>
    /// Логика взаимодействия для DESCTOP.xaml
    /// </summary>
    public partial class DESCTOP : Page
    {

     
        public DESCTOP()
        {
      
            InitializeComponent();
        }
         
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
          //  string[] path1 = ofd.FileName;
             string path = ofd.FileName;
            string directoryPath = System.IO.Path.GetDirectoryName( Convert.ToString(path));

            Console.WriteLine(directoryPath);
            RES.Text = directoryPath;


           
            //DirectoryInfo directory = new DirectoryInfo(path);

            //path = path.Substring(0, path.Length - path.Length);
            //var my = Convert.ToString(directory.FullName);
            Console.WriteLine("Selected file: " + path);
            //RES.Text = my;
            //var my = RES.Text;
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() !=  )
            //{
            //    my = ofd.FileName;
            //}


        }
    }
}
