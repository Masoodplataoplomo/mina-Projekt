using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int Tid = int.Parse(tbxTid.Text);    // hämtar text från textboxen och gör om den till tal. 
            int Timmar = Tid / 3600;     // delad på 3600 för att få ut hur många timmar det blir. 
            int Minuter = Tid / 60 - Timmar * 60; // delad på 60 för att få ut minuter och minus timmar annars ränkar den ut alla minuterna. 
            int Sekunder = Tid % 60;  // delar på 60 för att få ut Sekunderna. 
            lblSvar.Text = Timmar + "Timmar" + Minuter + "Minuter" + Sekunder + "Sekunder";  // visa svaret. 

                

        }
    }
}
