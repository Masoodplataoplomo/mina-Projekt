using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning11._4
{
    internal class Course
    {
        public string Name;
        public string Code;
        public int Points;
        public DateTime Start; 
        public DateTime End;

        public bool IsActive(DateTime inDate) 
        {
            if (inDate > Start && inDate < End)
            {
                return true;
            }
            else 
            {
             return false;
            }
        }


    }
}
