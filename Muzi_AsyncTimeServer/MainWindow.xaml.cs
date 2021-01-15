using Muzi_SocketAsyncLib;
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

namespace Muzi_AsyncTimeServer
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AsyncSocketServer mServer;
        public MainWindow()
        {
            InitializeComponent();
            mServer = new AsyncSocketServer();
        }

        private void Btn_Ascolta_Click(object sender, RoutedEventArgs e)
        {
            mServer.InizioAscolto();
        }

        private void Btn_Disconnetti_Click(object sender, RoutedEventArgs e)
        {
            mServer.ChiudiConnessione();
        }

        private void Btn_Invia_Click(object sender, RoutedEventArgs e)
        {
            mServer.InviaATutti(Txt_Messaggio.Text);
        }
    }
}
