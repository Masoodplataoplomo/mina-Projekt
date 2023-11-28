using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uppgift_10._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            string text = tbxGemen.Text;
            if (text.Length > 0)
            {
                char ch = char.ToUpper(text[0]);
                string result = text.Remove(0, 1).Insert(0, ch.ToString());
                tbxVersal.Text = (" " + result);
            }
            else
            {
                MessageBox.Show("Please enter a letter.");
            }
        }
    }
}
