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
        public int Temps { get { return _temps; } set {  } }
        public int NbPoinTemps { get { return _nbPoinTemps; } set {  } }
        public int NbEssais { get { return _nbEssais; } set {  } }
        public int ScoreDepart { get; set; }
        public Options() { }
        public Options(int NombreManches = 1, int Temps = 60, int NbPoinTemps=1, int NbEssais=7)
        {
            this.NombreManches = NombreManches;
            this.Temps = Temps;
            this.NbPoinTemps = NbPoinTemps;
            this.NbEssais = NbEssais;
        }
        public void SaveXML(string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Options));
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            writer.Serialize(file, this);
            file.Close();
        }
        public void LoadXML(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Options));
            FileStream file = new FileStream(path, FileMode.Open);
            serializer.Deserialize(file);
            file.Close();
        }
    }
}
