using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int Tal = int.Parse(tbxTal.Text);       //hämta text från textboxen och gö om den till tal 
            int Tal1 = Tal + 500;                  //plusa på 500 för att få det avrundat till heltal 
            int Tal2 = Tal1 / 1000;               //dela på tusen för att få bort alla decimaltal
            int Tal3 = Tal2 * 1000;              //multiplcera med 1000 igen för att få hetal
            lblSvar.Text = Tal3.ToString();     //visa svar 
        }
    }
}
