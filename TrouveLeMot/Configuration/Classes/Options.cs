using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Classes
{
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
    }
}
