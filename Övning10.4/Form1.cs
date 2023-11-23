using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._4
{

       public partial class Form1 : Form
        {
            bool rita = false;
            public Form1() 
            {
                InitializeComponent();
            }

            private void btnKör_Click(object sender, EventArgs e)
            {
            rita = true;
            Invalidate(); 
            }
        protected override void OnPaint(PaintEventArgs e)
        {
           if (rita) 
            {
            Graphics g = e.Graphics;
                int höjd = int.Parse(tbxHöjd.Text);     // hämta ett siffra från textboxen. 
                ritaTriangel(g, höjd);
            }
          
        }
            void ritaTriangel(Graphics g, int höjd) 
            {
            SolidBrush brush = new SolidBrush(Color.DarkSlateGray);  // här så kan du välja vilken färg du vill ha. 
            for (int rad = 1; rad <= höjd; rad++)  // hät anger du höjden för raden större eller lika med. 
            {
                for (int kolumn = 1; kolumn <= rad; kolumn++)  // här anger du kolumn större eller lika med. 
                {
                    g.FillEllipse(brush, (höjd + 1 + 20 ) * 20 - kolumn * 20, 70 + rad * 20, 20, 20);  // här så kan skjustera vart du vill har kulerna. 
                }
            }

            }

        private void tbxHöjd_TextChanged(object sender, EventArgs e)
        {
            rita = false;
            Invalidate();
        }
    }


        
    
}
