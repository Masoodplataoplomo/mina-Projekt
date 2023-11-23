using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int nivå = int.Parse(tbxNivå.Text);
            string tabell = ""; 
            int tabellvärde = 0;
            for (int i = 1 ; i <= nivå ; i++) 
            {
                for (int j=1; j <=10 ; j++) 
                {
                    tabell = tabell + (i * j) + "\t";
                }
                tabell = tabell + "\r\n";
                
            }
            tbxUtdata.Text = tabell;


        }
    }
}
