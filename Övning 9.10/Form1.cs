using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._10
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2button1_Click(object sender, EventArgs e)
        {
            int[] tal;
            tbxRad1.Clear();
            tbxRad2.Clear();
            tbxRad3.Clear();
            tal  = new int[6];
            for (int i = 0; i< tal.Length;  i++) 
            {
                tal[i] = generator.Next(1, 21);     // den tar ett tal mellan 1 till 21 
                tbxRad1.AppendText(tal[i] + "\r\n");
            }
            for (int i = 0; i < tal.Length; i++) 
            {
                tal[i] = generator.Next(1, 21);
                tbxRad2.AppendText(tal[i] + "\r\n");
            }
            for(int i = 0; i < tal.Length; i++) 
            {
                tal[i] = generator.Next(1, 21);
                tbxRad3.AppendText(tal[i] + "\r\n");
            }
            
            
        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            if (lbxMeny.SelectedIndex == 0) tbxVal.Text = tbxRad1.Text;    // den här koden betyder att man kan trycka på ett alternativ 
            else if (lbxMeny.SelectedIndex == 1) tbxVal.Text = tbxRad2.Text;
            else if (lbxMeny.SelectedIndex == 2) tbxVal.Text = tbxRad3.Text;
        }
    }
   
}
