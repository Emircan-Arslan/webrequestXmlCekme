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
using System.Windows.Shapes;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.Linq;


namespace dgfgfg
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Getir_Click(object sender, RoutedEventArgs e)
        {

            Uri url = new Uri("https://www.onedio.com");

            WebClient client = new WebClient(); // alıcı 
            client.Encoding = System.Text.Encoding.UTF8; // yazıları tr ye düzeltmek için 

            // yazdığımız url içerisindeki bilgileri client yardımı ile string değişkene atarız
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html); // html i yükle 

            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//a");

            foreach (HtmlNode baslik in basliklar)
            {
                string link = baslik.Attributes["href"].Value;
                list1.Items.Add(baslik.InnerText);
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Window2 ww = new Window2();
            ww.Show();
            this.Close();
        }
    }
}
