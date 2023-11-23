using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Omkrets (  double radie ) 
            
        { 
            
           
            
            return radie * 2 * Math.PI;       // här sker det räkningen 

        }
        

        private void beräkna_Click(object sender, EventArgs e)
        {
            double radie = double.Parse(tbxRadie.Text);
            double resultat = Omkrets (radie);
            tbxOmkrets.Text = resultat.ToString();   // visar reultatet i textbox 
            
                
        }
    }
}
