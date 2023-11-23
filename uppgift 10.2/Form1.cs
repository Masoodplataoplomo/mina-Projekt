using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvissa_Click(object sender, EventArgs e)
        {
            char resultat = bestämtecken(double.Parse(tbxtal.Text));
            tbxtecken.Text = resultat.ToString();   
        }
        char bestämtecken(double tal) 
        {
            char tecken = ' '; 
            if (tal > 0)
            {
                tecken = '+';
            }
            else if (tal < 0)
            {
                tecken = '-';
            }

            return tecken;  
        }
        
        
        
    }
   
}
