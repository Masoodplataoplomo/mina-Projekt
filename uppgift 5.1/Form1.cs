using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tal = int.Parse(tbxTal.Text);        //Hämtar text från textboxen och gör om den till tal. 
            int Tal2 = Tal + 1;                     //Adderar med 1. 
            int Tal3 = Tal2 * 2;                   //multiplicerar med 2.
            int Tal4 = Tal3 - 6;                  //minus 6.
            int Tal5 = Tal4 /2;                  //delaat på 2 halverar. 
            int Tal6 = Tal5 + 3;                //plusar på 2.
            int Tal7 = Tal6 - Tal;             //subtraherar talet tal.
            lblSvar.Text = Tal7.ToString();   //visa svar. 
             
        }
    }
}
