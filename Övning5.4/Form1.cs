using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnKör_Click(object sender, EventArgs e)

        {
            int talA = int.Parse(tbxA.Text);                       //Hämtar text från textboxen och gör om den till tal.       
            int talB = int.Parse(tbxB.Text);                      //Hämtar ut text från textboxen ocg g´ör om den till tal.  
            int talC = int.Parse(tbxC.Text);                     //Hämtar ut text från textboxen och gör om dem till tal. 
            bool karta = talA <= talB && talC >= talB;          //här så gör vi en ordning om att vilka som ska vara större än den andra. 
            lblSvar.Text = karta.ToString();                   //visa i lblSvar om det är sant eller falskt. 
        }
    }
}
