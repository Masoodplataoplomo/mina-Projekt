using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_11._7
{
    internal class Soldat
    {
        public int poäng;
        public string namn;

        public Soldat(int poäng, string namn)
        {
            this.poäng = poäng;
            this.namn = namn;
        }

        public override string ToString()
        {
            return namn + " poäng:" + poäng; 
        }
    }
}
