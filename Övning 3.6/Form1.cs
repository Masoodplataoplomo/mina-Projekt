using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKör_Click(object sender, EventArgs e)
        {
         string FörNamn = tbxFörnamn.Text;                                                                              // den hämtar texten från textboxen och ger till Förnamn 
            char förnamn = FörNamn[0];                                                                                 //  du får ett tecken 
            string Efternamn = tbxEfternamn.Text;                                                                     //   den hämtar texten från textboxen och ger till Efternamn
            char efternamn = Efternamn[0];                                                                           //    du får en tecken 
            lblSvar.Text =  " Har initialerna " + förnamn.ToString() + " . " + efternamn.ToString() + " . ";        //     visa svaret i etiketen 
            
         
             
        }
    }
}
