using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string text = tbxBlopp.Text;
            int uttag = int.Parse(text);
            uttag = uttag / 100; 
            uttag = uttag * 100;
            tbxUttag.Text =  + uttag + " kr ";

        }
    }
}
