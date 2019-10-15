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
using System.Net;


namespace dgfgfg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void VerileriGetir_Click(object sender, RoutedEventArgs e)
        {

            string adres = "https://www.youtube.com/?hl=tr&gl=TR";

            WebRequest istek = HttpWebRequest.Create(adres); // adres değişkenindeki adrese istek oluştur 

            WebResponse cevap = istek.GetResponse(); // isteği istedikkten sonra geri döünüş cevabını response ile alırız

            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); // dönen bilgileri oku 

            string gelen = donenBilgiler.ReadToEnd(); // bilgileri oku ve sonlandır

            int baslangic = gelen.IndexOf("<title>") +7 ; // 7 yazmamızın sebebi tırnak içerisindeki değeri de yazmasın diye 

            int bitis = gelen.Substring(baslangic).IndexOf("</title>");

            string baslik = gelen.Substring(baslangic, bitis);

            MessageBox.Show(baslik);


      


        }

        private void Gecis_Click(object sender, RoutedEventArgs e)
        {
           
          
            Window1 ww = new Window1();
            ww.Show();
        }
    }
}
