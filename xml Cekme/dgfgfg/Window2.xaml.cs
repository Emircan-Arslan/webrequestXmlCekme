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
using System.Xml;


namespace dgfgfg
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void DovizGetir_Click(object sender, RoutedEventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmldoc = new XmlDocument(); // dokumnet oluşturduk
            xmldoc.Load(bugun);// link içerisindeki dokanları yükledik 
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value); // site içerisinde tarih değeri alanı ismi
            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            label1.Content = string.Format("Tarih {0} USD ; {1} ", tarih.ToShortDateString(), USD);

        }
    }
}
