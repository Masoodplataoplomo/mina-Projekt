using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3._4B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string text = tbxsvar.Text; 
            int uttag = int.Parse(text);
            uttag = uttag / 100;
            uttag = uttag * 100; 
            int uttag2 = int.Parse(text); 
            uttag2 = uttag2 / 500;
            uttag2 = uttag2 * 500;
            uttag = uttag - uttag2;
            lblUttag2.Text = " uttag i 500 sedlar: " + uttag2 + " uttag i 100 sedlar: " + uttag; 

        }
    }
}
