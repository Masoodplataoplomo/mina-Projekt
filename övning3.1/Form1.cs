using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse( tbxTal.Text );     // omvandla texten i textrutan till ett tal.
            int kvadrat = tal * tal;               // Beräkna kvadraten. 
            string text = kvadrat.ToString();     // Omvandla talet till text.
            lblKvadrat.Text = text;              // Visa resultatet i etiketten.
        }

    }
}
