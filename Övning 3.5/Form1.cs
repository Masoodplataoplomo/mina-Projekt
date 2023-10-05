using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Namn = tbxNamn.Text;
            int Födelseår = int.Parse (tbxFödd.Text);
            int David = Födelseår + 50;
            lblInfo.Text = David.ToString() +" fyller " + Namn + " 50år ";

        }
    }
}
