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

namespace övning7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          int ålder = int.Parse(tbxÅlder.Text);
            int kr = 30;
            if (ålder > 15 && ålder <65  )
                
            {
                lblSvar.Text = " Resan kosatr " + kr;
            }
             else 
            { 
             lblSvar.Text = " resan kostar 20"; 
            }
        }
    }
}
