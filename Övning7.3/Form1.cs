using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random slump = new Random();    
            int resultat = slump.Next(1, 7);
            lblResultat.Text = resultat.ToString();
            if (resultat == 6) 
            {
                lblResultat.Text =resultat.ToString();
                MessageBox.Show(" Grattis Goli ", "Meddelande", MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
        }

    }
}
