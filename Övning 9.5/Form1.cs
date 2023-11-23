using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int start = int.Parse(tbxStart.Text);
            int slut = int.Parse(tbxSlut.Text);
            int steg = int.Parse(tbxSteg.Text);
            do

            {
                tbxUt.AppendText(start +" ");
                start = start + steg;
            }
            while (start <= slut);
        } 
    }
}
