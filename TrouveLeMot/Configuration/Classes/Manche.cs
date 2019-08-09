using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveLeMot
{
    public class Manche
    {
        
        private int _points;
        private int _nbErreurs;
        private string _motCach;
        private bool _motTrouve;

       
        public int Points { get; set; }
        public int NbErreurs { get; set; }
        public string MotCach { get; set; }
        public bool MotTrouve { get; set; }


    }
}
