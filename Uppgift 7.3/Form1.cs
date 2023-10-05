using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._3
{
    public partial class btnOK : Form
    {
        public btnOK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double längd = double.Parse(tbxlängd.Text);
            double vind = double.Parse(tbxvind.Text);
            if (längd > 7.92 && vind < 2.0)
            {
                tbxSvar.Text = " Gratis nytt rekord! ";
            }
            else 
            {
                tbxSvar.Text = " Tyvärr inget nytt rekord! "; 
            }
        }
    }
}
