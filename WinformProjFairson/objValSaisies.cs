using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProjFairson
{
    internal class objValSaisies
    {
        public int NumSaisie;
        public string ValSaisie;

        public objValSaisies(int numSaisie, string valSaisie)
        {
            NumSaisie = numSaisie;
            ValSaisie = valSaisie;
        }

        override public string ToString()
        {
            return "Saisie n°" + NumSaisie + " : " + ValSaisie;
        }
    }
}
