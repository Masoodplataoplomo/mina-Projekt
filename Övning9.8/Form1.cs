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

namespace Övning9._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


            
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Color röd = Color.Red;
            Pen penna = new Pen(Color.Red);
            Graphics g = e.Graphics;
            for (int rad = 1; rad <= 10 ; rad++)         
            {
                for (int kol = 1; kol <= rad; kol++)

                {
                 g.DrawEllipse(penna, kol * 10,rad * 10, 10, 10);
                }
            }


        }
    } 
}
