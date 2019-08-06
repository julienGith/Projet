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
            XmlDocument doc = new XmlDocument();
            doc.Load(@"test.xml");
            listBox1.Items.Add(doc.InnerText);//Remplissage de la listbox
        }


    }
}
