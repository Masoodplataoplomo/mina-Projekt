using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string Tecken = tbxTecken.Text;                        // Den hämtar Tecken från textboxen och ger ett tecken.
            char Gay = Tecken[0];                                 //  du får ett tecken genom att ta första tecknet i string " tecken " 
            int hej = Gay;                                       //   du gör om tecken till kod.  
            lblSvar.Text = Tecken + " Har koden " + hej;        //    visa tecken i etiketen.
        }
    }
}
