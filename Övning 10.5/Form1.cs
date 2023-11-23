using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnByt_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(Tal1.Text); 
            int tal2 = int.Parse(Tal2.Text);
            int tal3 = int.Parse(Tal3.Text);    
            int tal4 = int.Parse(Tal4.Text);
            byt(ref tal1, ref tal2);          // om du tar bort ref så byter den inte länger eller den byter två gånger men visar inget svar.  
            byt(ref tal3, ref tal4);
            
            
            Tal1.Text = tal1.ToString();
            Tal2.Text = tal2.ToString();
            Tal3.Text = tal3.ToString();
            Tal4.Text = tal4.ToString();
            
            
        }
        void byt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

      
    }
   
}
