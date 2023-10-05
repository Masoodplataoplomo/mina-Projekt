using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int minaPengar = int.Parse(tbxPengar.Text );              
            int varansPris = int.Parse(tbxPris.Text);
            bool jagHarRåd = varansPris <= minaPengar;
            string info =" Köp varan: " + jagHarRåd.ToString();
            lblSvar.Text = info;
        }
    }
}
