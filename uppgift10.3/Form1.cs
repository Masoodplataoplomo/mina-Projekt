using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift10._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnvisa_Click(object sender, EventArgs e)
       
        {
            bool svar = ärSiffra(tbxtecken.Text[0]);

        }
        bool ärSiffra(char tecken)
        {
            
            int kod = (int)tecken; 

            if (kod >= 48 && kod <57) 
            {
                
                tbxresultat.Text = " Tecknet är en siffra ";
                return true;
            }
            else 
            {
                tbxresultat.Text = " Tecknet är en bokstav";
            }
            return false;

        }
    }
}
