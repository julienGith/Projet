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
using System.Xml;
using TrouveLeMot;

namespace Configuration
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChargeLexique();
        }
        Lexique lexique = new Lexique();
        private void ChargeLexique()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"test.xml");
            XmlNodeList Xn = doc.SelectNodes("//string");
            foreach (XmlNode xNode in Xn)
            {
                listBoxLex.Items.Add(xNode.InnerText);
                lexique.Add(xNode.InnerText);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        
        {
            listBoxLex.Items.Add(txtBoxMot.Text);
            lexique.Add(txtBoxMot.Text);
            lexique.SaveXML(@"test.xml");
            txtBoxMot.Clear();
        }

        private void BtnTransfert_Click(object sender, RoutedEventArgs e)
        {
            listBoxCible.Items.Add(listBoxLex.SelectedItem);
            listBoxLex.Items.Remove(listBoxLex.SelectedItem);
        }
        private void BtnSupr_Click(object sender, RoutedEventArgs e)
        {
            listBoxLex.Items.Add(listBoxCible.SelectedItem);
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            object selected = listBoxLex.SelectedItem.ToString();
            lexique.Remove(selected.ToString());
            lexique.SaveXML(@"test.xml");
            listBoxLex.Items.Remove(listBoxLex.SelectedItem);
        }
    }
}
