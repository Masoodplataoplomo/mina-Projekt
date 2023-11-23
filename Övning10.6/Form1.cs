using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void indata(out int t1, out int t2)
        {
            t1 = int.Parse(tbxHöjd.Text);
            t2 = int.Parse(tbxRadie.Text);
            int tal3 = minst(t1, t2);
            tbxVolym.Text = tal3.ToString();
        }
        int minst(int tal1, int tal2)
        {
            int volym = tal1;
            if (tal2 < tal1)
            {
                volym = tal2;
            }
            return volym;
        }

        private void tbxRadie_TextChanged(object sender, EventArgs e)
        {
            tbxVolym.Text = "";
        }

        private void tbxHöjd_TextChanged(object sender, EventArgs e)
        {
            tbxVolym.Text = "";
        }
    }

}
