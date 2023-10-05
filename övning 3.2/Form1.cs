using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal1.Text);           //Omvandla texten i rutan till ett tal.
            int Tal = int.Parse(tbxTal2.Text);          //Omvandla texten i rutan till ett tal.
            int kvadrat = tal * tal;                   //Beräkna kvadraten.
            String text = kvadrat.ToString();         //Omvandla talet till text. 
            lblSumma .Text = text;                   // Visa summan i etiketen. 
        }
    }
}
