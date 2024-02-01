using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ärprimtal(int n)    
        {
            bool primtal = true;
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;   // här så sker det uträkningen 
            for (int i =  3; i < n/2;i++) 
            {
            if (n % i == 0) primtal = false;
            }
            return primtal;
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbxTal.Text);       // här så tar den emot beräkningen och visar upp den 
            bool primtal = ärprimtal(n);
            tbxVisa.Text = primtal.ToString();
        }
    }
}
