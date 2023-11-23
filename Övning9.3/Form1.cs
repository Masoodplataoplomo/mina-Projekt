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

namespace Övning9._3
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e) 
        
        { 
            Graphics g = e.Graphics;
            Pen penna = new Pen(Color.Red);
            int radie = 5;                      // den första cirkeln ska börja på radie 5. 
            do 

            {
                g.DrawEllipse(penna, 200 - radie, 200 - radie, radie *2,  radie *2 );   // här så anger man cikelns höjd, bredd, längd och sotrlek.  
                radie = radie + 5;
            }
             while (radie <= 50);             // den sista cirkeln ska vara 10 gånger större än 5 då blir det 50. 
          

        }
        public Form1()
        {
            InitializeComponent();
        }


    }
}
