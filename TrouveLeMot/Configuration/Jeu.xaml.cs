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
using TrouveLeMot;


namespace Configuration
{
    /// <summary>
    /// Logique d'interaction pour Jeu.xaml
    /// </summary>
    public partial class Jeu : Window
    {
        Mots atrouver = new Mots();
        Options options = new Options();
        int i = 1;
        int j = 1;
        

        public Jeu()
        {
            InitializeComponent();
            options.LoadXML(@"Options.xml");
            
        }
        private void ChargeMots()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"mots choisis.xml");
            XmlNodeList Xn = doc.SelectNodes("//string");
            foreach (XmlNode xNode in Xn)
            {
                atrouver.Ajouter(xNode.InnerText);
            }

        }
        private void TxtBmotCach_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            ChargeMots();
            txtBmotCach.Text = atrouver.MotCach;
            atrouver.Remove(txtBmotCach.Text);
            atrouver.SaveXML(@"mots choisis.xml");
        }

        private void TxtBnbManches_TextChanged(object sender, TextChangedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Options.xml");
            XmlNodeList Xn = doc.SelectNodes("//NombreManches");
            foreach (XmlNode xNode in Xn)
            {
                options.NombreManches = int.Parse(xNode.InnerText);
                
            }
            txtBnbManches.Text = options.NombreManches.ToString();
            
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (i<int.Parse(txtBnbManches.Text))
            {
                if (atrouver.Count>0)
                {
                 atrouver.Remove(txtBmotCach.Text);
                }
                txtBmotCach.Text = atrouver.MotCach;
                txtBmanche.Text = (++i).ToString();
            }
        }

        private void TxtBmanche_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBmanche.Text = i.ToString();
        }

        private void TxtBnbEssais_TextChanged(object sender, TextChangedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Options.xml");
            XmlNodeList Xn = doc.SelectNodes("//NbEssais");
            foreach (XmlNode xNode in Xn)
            {
                options.NbEssais = int.Parse(xNode.InnerText);

            }
            txtBnbEssais.Text = options.NbEssais.ToString();

        }

        private void TxtBessai_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBessai.Text = i.ToString();
        }

        private void BtnTry_Click(object sender, RoutedEventArgs e)
        {
            char[] tabMotCach = txtBmotCach.Text.ToCharArray();
            char[] tabMotJoueur = txtBjoueur.Text.ToCharArray();
            foreach (char item in tabMotJoueur)
            {
                if (tabMotCach.Contains(item) & !txtBlettres.Text.Contains(item.ToString()))
                {
                    
                    txtBlettres.Text += item.ToString();
                }
            }
            if (txtBjoueur.Text == txtBmotCach.Text)
            {
                
            }
            if (i < int.Parse(txtBnbEssais.Text))
            {
                txtBessai.Text = (++i).ToString();
            }
        }

        private void TxtBjoueur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LstBlettres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
