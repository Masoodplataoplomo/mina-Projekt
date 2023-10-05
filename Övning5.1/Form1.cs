using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string text = tbxTid.Text;                                                            // tar tecknet från textboxen och omvandlar den till text. 
            int månader = int.Parse (text);                                                      //  tar siffror och omvanldar den till text. 
            int år = månader/ 12;                                                               //   delar månader till 12. 
            int månader2 = månader % 12;                                                       //    delar resten av månaderna. 
            lblSvar.Text = år + " år " + " och " + månader2 + " månader ";                    //     svar hur många år och månader. 


        }
    }
}
