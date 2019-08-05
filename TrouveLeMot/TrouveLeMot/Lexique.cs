using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveLeMot
{
    [Serializable()]
   public class Lexique : List<string>
    {
        public Lexique(){ }
        Lexique lexique = new Lexique();

        public string mot;

        public new void Add(string mot)
        {
            bool trouve = false;
            if (lexique.Contains(mot))
            {
                trouve = true;
            }
            if (!trouve)
            {
                base.Add(mot);
            }
        }
        public new void Remove(string mot)
        {
            bool trouve = false;
            if (lexique.Contains(mot))
            {
                trouve = true;
            }
            if (!trouve)
            {
                base.Remove(mot);
            }
        }
        public void Pioche(string mot)
        {
            Random rand = new Random();
            int aléatoire = 0;
            aléatoire = rand.Next(0, lexique.Count - 1);
            base.Add(lexique[aléatoire]);
        }
        #region 
        /// <summary>
        /// Methodes de sauvegarde/chargement du Lexique.
        /// </summary>
        /// <param name="path"></param>
        public void SaveXML(string path)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Salaries));
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }
        public void LoadXML(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Salaries));
            FileStream file = new FileStream(path, FileMode.Open);
            serializer.Deserialize(file);
        }
        #endregion
    }
}
