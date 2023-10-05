using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int dag = int.Parse(tbxnr.Text);
            if (dag == 1)
            {
                lblSvar.Text = " Måndag "; 
            }
            if (dag == 2)
            {
                lblSvar.Text = " Tisadag "; 
            }
            if (dag == 3) 
            {
                lblSvar.Text = " Onsdag "; 
            }
            if (dag == 4)
            {
                lblSvar.Text = " Torsdag "; 
            }
            if (dag == 5)
            {
                lblSvar.Text = " Fredag "; 
            }
            if (dag == 6) 
            {
                lblSvar.Text = " Lördag "; 
            }
            if(dag == 7) 
            {
                lblSvar.Text = " Söndag "; 
            }
            else if (dag >7 || dag <1) 
            {
               lblSvar.Text = " fel inmatning "; 
            }

        }
    }
}
