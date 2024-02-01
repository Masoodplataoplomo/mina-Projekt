using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnberäkna_Click(object sender, EventArgs e)
        {
            int bas = int.Parse(tbxBas.Text);
            int exponent = int.Parse(tbxBas.Text);
            int svar = potens( bas, exponent);
            tbxVisa.Text = bas + " upphöjt till " + exponent+ " är " + svar.ToString();
        }

        int potens( int bas, int exponent) 
        {
            int potens = bas;  
            for (int i = 0; i < exponent; i++)
            {
                potens = (potens * bas ); 
                

            }
            return potens; 
        }

    }
}
