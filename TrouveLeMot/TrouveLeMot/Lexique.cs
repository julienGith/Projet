using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveLeMot
{
    class Lexique : List<string>
    {

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
        public void Pioche()
        {
            Random rand = new Random();
            int aléatoire = 0;
            aléatoire = rand.Next(0, lexique.Count-1);
            base.Add(lexique[aléatoire]);
        }
    }
}
