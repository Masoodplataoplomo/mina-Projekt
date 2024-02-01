using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistera_Click(object sender, EventArgs e)
        {
            löpning löpning = new löpning(int.Parse(tbxsträcka.Text),tbxnamn.Text, int.Parse(tbxtid.Text));
            lbxlöppass.Items.Add(löpning);
        }
    }
}
