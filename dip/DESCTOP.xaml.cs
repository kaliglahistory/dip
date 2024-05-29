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
using Xceed.Wpf.Toolkit;
using System.Net.Sockets;
using System.Net;
using System.Net;
using System.Net.Sockets;
using System.Text;



namespace dip
{
    /// <summary>
    /// Логика взаимодействия для DESCTOP.xaml
    /// </summary>
    public partial class DESCTOP : Page
    {
        IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
        Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public DateTime SelectedDate
        {
            get; set;}
        public DESCTOP()
        {
      
            InitializeComponent();
            this.DataContext = this;
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

        private async Task Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                tcpListener.Bind(ipPoint);
                tcpListener.Listen();    // запускаем сервер
                Console.WriteLine("Сервер запущен. Ожидание подключений... ");

                while (true)
                {
                    // получаем подключение в виде TcpClient
                     var tcpClient = await tcpListener.AcceptAsync();
                    // определяем буфер для получения данных
                    List<byte> response = [];
                    byte[] buffer = new byte[512];
                    int bytes = 0; // количество считанных байтов
                                   // считываем данные 
                    do
                    {
                        bytes = await tcpClient.ReceiveAsync(buffer);
                        // добавляем полученные байты в список
                        response.AddRange(buffer.Take(bytes));
                    }
                    while (bytes > 0);
                    // выводим отправленные клиентом данные
                    var responseText = Encoding.UTF8.GetString(response.ToArray());
                    Console.WriteLine(responseText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
