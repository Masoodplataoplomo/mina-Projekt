using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int talA = int.Parse(tbxA.Text);
            int talB = int.Parse(tbxB.Text);
            int talC = int.Parse(tbxC.Text);
            int Kvadrat = talA + talB + talC;
            String text = Kvadrat.ToString();
            double medel;
            medel = Kvadrat / (double)3;
            String text2 = medel.ToString();
            lblMedel.Text = text2;  
            lblSumma.Text = text;
            

        }
    }
}
