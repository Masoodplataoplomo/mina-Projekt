using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift10._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int timmar;
            int minuter;
            int sekunder;
            int tid = int.Parse(tbxTid.Text);
            Tiden(out timmar, out minuter, out sekunder, tid);
            tbxVisa.Text = timmar + " H " + minuter + " min " + sekunder + " sek ";
        }
        void Tiden(out int timmar, out int minuter, out int sekunder, int tid)      
        {
            timmar = tid / 3600;
            minuter = tid % 3600/60;
            sekunder = tid % 60;
        }

    }
}
