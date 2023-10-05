using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlytta_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbxX.Text);               //du gör om det som står i textboxX till en kod. 
            int y = int.Parse(tbxY.Text);              //du gör om det som står i textboxY till en kod. 
            Point posisiton = new Point(x, y);        //jag har en tom variabel och skapar en variabel och ger den till den tomma variabeln 
            btnFlytta.Location = posisiton;          //jag ger dem en position att flytta till.   

        }
    }
}
