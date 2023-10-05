using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(tbxtal1.Text);
            double tal2 = double.Parse(tbxtal2.Text);
            if (tal1.CompareTo(tal2) < 0)
            {
                tbxSvar.Text = tal1 + " Minsta talet är ";
            }
            else
            {
                tbxSvar.Text = (tal1 > tal2 ? tal1 : tal2);
            }
            
              
        }
    }
}
