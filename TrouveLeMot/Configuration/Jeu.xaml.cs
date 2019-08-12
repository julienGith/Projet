using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
using System.Windows.Threading;


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
        int j = 0;
        DispatcherTimer chrono = new DispatcherTimer();

        public Jeu()
        {
            InitializeComponent();
            options.LoadXML(@"Options.xml");
            chrono.Start();
            chrono.Tick += chrono_Tick;
            chrono.Interval = new TimeSpan(0, 0, 1);
        }
        private void chrono_Tick(object sender, EventArgs e)
        {
            j++;
            txtBcompteur.Text = j.ToString();
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
            lblWinOrLose.Content = "";
            txtBlettres.Text = "";
            txtBnote.Text = "Aidez-vous en formant des mots avec les lettres trouvées. Les lettres trouvées peuvent être présentes plusieurs fois dans le mot caché. ";
            txtBjoueur.Text = "Entrez un mot ou des lettres et tentez";
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
            int penalty = int.Parse(txtBessai.Text);
            foreach (char item in tabMotJoueur)
            {
                if (tabMotCach.Contains(item) & !txtBlettres.Text.Contains(item.ToString()))
                {
                    
                    txtBlettres.Text += item.ToString();
                }
            }
            if (txtBjoueur.Text == txtBmotCach.Text)
            {
                lblWinOrLose.Content = "Bravo ! Vous avez trouvé le mot caché";
                chrono.Stop();
                int score = options.Temps - int.Parse(txtBcompteur.Text) - penalty;
                lblScore.Content = score.ToString();
            }
            if (txtBessai.Text==txtBnbEssais.Text)
            {
                lblWinOrLose.Content = "Perdu !";
            }
            if (i < int.Parse(txtBnbEssais.Text))
            {
                txtBessai.Text = (++i).ToString();
            }
        }

        private void TxtBtemps_TextChanged(object sender, TextChangedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Options.xml");
            XmlNodeList Xn = doc.SelectNodes("//Temps");
            foreach (XmlNode xNode in Xn)
            {
                options.Temps = int.Parse(xNode.InnerText);

            }
            txtBtemps.Text = options.Temps.ToString();
        }

        private void TxtBcompteur_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBcompteur.Text == options.Temps.ToString())
            {
                chrono.Stop();
                lblWinOrLose.Content = "Perdu ! temps écoulé";
            }
        }

    }
}
