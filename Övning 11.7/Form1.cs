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

namespace Övning_11._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistera_Click(object sender, EventArgs e)
        {
            Soldat soldat = new Soldat(int.Parse(tbxpoäng.Text), tbxnamn.Text);
            lbxsoldater.Items.Add(soldat); 
        }
    }
}
