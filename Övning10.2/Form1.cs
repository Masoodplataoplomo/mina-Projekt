﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVolym_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(tbxRadie.Text);
            int tal2 = int.Parse(tbxHöjd.Text);
            int tal3 = minst( tal1, tal2);
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
