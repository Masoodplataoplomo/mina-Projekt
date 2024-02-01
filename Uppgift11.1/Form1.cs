using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Styrketräning styrketräning = new Styrketräning(int.Parse(tbxrep.Text), int.Parse(tbxrep.Text), int.Parse(tbxvikt.Text), tbxövning.Text); 
            lbxträningsprogram.Items.Add(styrketräning);

            for(int i = 0; i <lbxträningsprogram.Items.Count; i++)
            {
                Debug.WriteLine(((Styrketräning)lbxträningsprogram.Items[i]).namn);
            }
            

        }
    }
}
