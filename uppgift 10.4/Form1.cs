using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._4
{
    public partial class Form1 : Form
    {
        int tal = 0; 
        public Form1()
        {
            InitializeComponent();
        }

       void ritaCirklar (Graphics g, int antal)
        {
           
            Color Röd = Color.Red;
            Pen penna = new Pen(Color.Red);
            for (int rad = 1; rad <= antal; rad++)  
            {
                for (int kol = 1; kol <= antal; kol++) 
                {
                 g.DrawEllipse(penna, (kol * 10 + rad * 11 + 300),(rad * 10 + 100),10,10);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             tal = int.Parse(tbxAntal.Text);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            
            if (tal>0) 
            {
                ritaCirklar(g, tal);
            }
        }
    }
}
