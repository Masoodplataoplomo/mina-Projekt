using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFörskjut_Click(object sender, EventArgs e)
        {
            string[] tecken = new string [3];
            tecken[0] = (tbxtecken1.Text);
            tecken[1] = (tbxtecken2.Text);
            tecken[2] = (tbxtecken3.Text);

            tbxtecken1.Text = "" + tecken[2];
            tbxtecken2.Text = "" + tecken[0];
            tbxtecken3.Text = "" + tecken[1];
            
        }


    }
}
