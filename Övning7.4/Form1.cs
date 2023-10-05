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

namespace Övning7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Antal =int.Parse(tbxAntal.Text);
            double prisperskiva = 9.9;
            double rabatt = 0;
            if (Antal <= 10)
            {

            }
            else if (Antal >= 10 && Antal <= 100)
            {
                rabatt = 10;
            }
            else 
            {
                rabatt = 15; 
            }
            double pris=   Antal * prisperskiva * ( 1 - rabatt /100);
            tbxpris.Text = " Kostnaden för " + Antal + " skivor är " + pris + " kronor "; 

        }
    }
}
