using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Configuration
{
    [Serializable()]
    public class Mots : List<string>
    {
        public Mots() { }
        public void Ajouter(string mot)
        {
                base.Add(mot);
        }
        public new void Remove(string mot)
        {
            base.Remove(mot);
        }
        public void SaveXML(string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Mots));
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            writer.Serialize(file, this);
            file.Close();
        }
    }
}
