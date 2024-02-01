using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning11._8
{ internal class löpning
    {
        public int sträcka;
        public string namn;
        public int tid;

        public löpning(int sträcka, string namn, int tid) 
        {
            this.sträcka = sträcka; 
            this.namn = namn;
            this.tid = tid;
        }
   
        public override string ToString() 
        {
         return namn +" : " +  sträcka + " km: " + tid +" min ";
        }
    }
}
