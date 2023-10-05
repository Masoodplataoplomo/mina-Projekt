using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fulltank = 50.0;
            double literpris = 14.50; 
            double Bensin = double.Parse(tbxBensin.Text);
            double tankarliter = fulltank - Bensin;
            double kr = literpris * tankarliter;
            if (Bensin < 10)
            {
                lblSvar.Text = " Tanka " + tankarliter + " Liter. Det kostar  " + kr + " kr ";

            }
            else
            {
                lblSvar.Text = " kör på "; 
            }
        }
    }
}
