using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double cirkelarea (double radie)

        {
            double area = Math.PI * radie  *radie;
            return area;
            
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            double radie = double.Parse(tbxRadie.Text);
            double area = cirkelarea(radie);
            tbxArea.Text = area.ToString();
        }
    }
}
