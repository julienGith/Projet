using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrouveLeMot;

namespace TrouveLeMot
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Test();
            Application.Run(new frmConfig());
            
            
        }
        static void Test()
        {
            Lexique lexique = new Lexique();
            lexique.Add("toto");
            lexique.SaveXML(@"C:\Users\julio\Desktop\repoGithHub\Projet\TrouveLeMot\test.xml");
        }
    }

}
