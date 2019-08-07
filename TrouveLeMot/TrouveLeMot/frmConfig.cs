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
            ChargeLexique();
        }

        Lexique lexique = new Lexique();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBoxLex.Items.Add(txtBoxMot.Text);
            lexique.Add(txtBoxMot.Text);
            lexique.SaveXML(@"test.xml");
            txtBoxMot.Clear();
        }
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
    }
}
