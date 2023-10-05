using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(tbxTal.Text);
            if (tal < 0)
            {
                tbxSvar.Text = " Talet är Negativ";
            }
            else if (tal > 0) 
            {
                tbxSvar.Text = " talet är Posetivt "; 
            }
        }
    }
}
