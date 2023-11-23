using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning10._7
{
    public partial class Form1 : Form
    {
        Random slump = new Random();
        int antal = 5;                        // om du flyttar den upp hit då behöver det inte stå i metoderna 
        int[] tärningar = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            
            kastaTärningar();
            visaTärningar();
            

        }
        void kastaTärningar() 
        {
        for (int i = 0; i <  antal; i++) 
            {
                int antalPrickar = slump.Next(1, 7);
                tärningar[i] = antalPrickar;
            }
        }
        void visaTärningar() 
        {
            tbxResultat.Text = " ";
            for (int i = 0; i < antal; i++)
            {
                tbxResultat.AppendText(" Tärning " + (i + 1) + ": " + tärningar[i] + "\r\n");
            }
        }
    }
     
}
