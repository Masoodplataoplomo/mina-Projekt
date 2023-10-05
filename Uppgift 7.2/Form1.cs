using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int slag = int.Parse(tbxslag.Text);
            if (slag  <150 ) 
            {
                tbxSvar.Text = " Försök igen "; 
            }
            else if (slag >190)
            {
                tbxSvar.Text = " Grattis ";
            }
        }
    }
}
