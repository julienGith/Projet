using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrouveLeMot
{
    [Serializable()]
    public class Options
    {
        private int _nombreManches;
        private int _temps;
        private int _nbPoinTemps;
        private int _nbEssais;
        private int _scoreDepart;
        public int NombreManches { get; set; }
        public int Temps { get; set; }
        public int NbPoinTemps { get; set; }
        public int NbEssais { get; set; }
        public int ScoreDepart { get; set; }

        public void SaveXML(string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Lexique));
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            writer.Serialize(file, this);
            file.Close();
        }
        public void LoadXML(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Lexique));
            FileStream file = new FileStream(path, FileMode.Open);
            serializer.Deserialize(file);
        }
    }
}
