using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tal1 = int.Parse(tbxTal1.Text);
            int Tal2 = int.Parse(tbxTal2.Text); 
            int Tal3 = Tal1 / Tal2;
            int Tal4 = Tal1 % Tal2;
            lblSvar.Text = Tal1 + "/" + Tal2 + " är " + Tal3 + " Hela " + Tal4 + "/" + Tal2; 
                


        }
    }
}
