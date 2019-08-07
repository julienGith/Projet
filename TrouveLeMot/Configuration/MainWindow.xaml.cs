using System;
using System.Collections.Generic;
using System.Data;
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
            }
        }
        private bool isSaisieValid(string saisie)
        {
            for (int i = 0; i < saisie.Length; i++)
            {
                if (char.IsDigit(saisie[i]))
                {
                    return false;
                }
            }
            if (listBoxLex.Items.Contains(saisie)) 
            {
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(saisie, "[/!@#?/}[}{]"))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(saisie))
            {
                return false;
            }
            if (saisie.Length<5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        
        {
            string saisie = txtBoxMot.Text;
            int tMot = txtBoxMot.Text.Length;
            if (isSaisieValid(saisie))
            {
                listBoxLex.Items.Add(saisie);
                lexique.Ajouter(saisie,tMot);
                lexique.SaveXML(@"test.xml");
                txtBoxMot.Clear();
            }
            e.Handled = true;
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

        private void RBtnDifficile_Checked(object sender, RoutedEventArgs e)
        {
            listBoxLex.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"test.xml");
            XmlNodeList Xn = doc.SelectNodes("//string");
            foreach (XmlNode xNode in Xn)
            {
                if (xNode.InnerText.Length > 7 & xNode.InnerText.Length < 11 & !listBoxLex.Items.Contains(xNode.InnerText))
                {
                    listBoxLex.Items.Add(xNode.InnerText);
                }
            }
        }

        private void RBtnExpert_Checked(object sender, RoutedEventArgs e)
        {
            listBoxLex.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"test.xml");
            XmlNodeList Xn = doc.SelectNodes("//string");
            foreach (XmlNode xNode in Xn)
            {
                if (xNode.InnerText.Length > 11 & !listBoxLex.Items.Contains(xNode.InnerText))
                {
                    listBoxLex.Items.Add(xNode.InnerText);
                }

            }
        }

        private void RBtnPerso_Checked(object sender, RoutedEventArgs e)
        {
            listBoxLex.Items.Clear();
            ChargeLexique();
        }

        private void RBtnFacile_Checked(object sender, RoutedEventArgs e)
        {
            listBoxLex.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"test.xml");
            XmlNodeList Xn = doc.SelectNodes("//string");
            foreach (XmlNode xNode in Xn)
            {
                if (xNode.InnerText.Length > 4 & xNode.InnerText.Length < 9 & !listBoxLex.Items.Contains(xNode.InnerText))
                {
                    listBoxLex.Items.Add(xNode.InnerText);
                }

            }
        }
    }
}
