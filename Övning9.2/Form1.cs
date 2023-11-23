using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVissa_Click(object sender, EventArgs e)
        {
            int räknare = 0;
            int slut = 55;
            int korn = 1; 
            while (räknare < slut) 
            {
             räknare++;
                korn = korn * 2; 
                tbxUdata.AppendText( " Ruta"+ räknare +  ":\t" + korn + " \r\n ");
            }
        }
    }
}
