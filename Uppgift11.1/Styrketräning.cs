using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift11._1
{
    internal class Styrketräning
    {
        public int set;
        public int rep;
        public int vikt;
        public string namn; 

        public Styrketräning(int set, int rep, int vikt, string namn)
        {
            this.set = set;
            this.rep = rep;
            this.vikt = vikt;
            this.namn = namn; 
        }
        public override string ToString() 
        {
         return namn + " ( " + set.ToString() +"/" + rep + "/" + vikt + "/" + ")";
        }
    }
}
