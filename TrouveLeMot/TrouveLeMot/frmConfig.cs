using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TrouveLeMot
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"test.xml");
            //listBoxLex.Items.Add(doc.InnerText);//Remplissage de la listbox
        }

        Lexique lexique = new Lexique();
        private void TxtBoxMot_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBoxLex.Items.Add(txtBoxMot.Text);
            lexique.Ajouter(txtBoxMot.Text);
            txtBoxMot.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lexique.SaveXML(@"test.xml");
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"test.xml");
            
            //listBoxLex.Items.Add(doc.);//Remplissage de la listbox
            //lexique.LoadXML(@"test.xml");
            //XmlNodeList nodes = doc.GetElementsByTagName("/String");
            //XmlElement element = doc.DocumentElement;
            //XmlAttributeCollection attribute = doc.Attributes.;
            XmlNodeList Xn = doc.SelectNodes("//string");
            foreach (XmlNode xNode in Xn)
            {
                listBoxLex.Items.Add(xNode.InnerText);
                lexique.Add(xNode.InnerText);
            }

            //foreach ( var item  in doc.Attributes)
            //{
            //    listBoxLex.Items.Add(attribute);
            //}
            ////listBoxLex.Items.Add(lexique);
            //listBoxLex.DataSource = lexique;


        }
    }
}
