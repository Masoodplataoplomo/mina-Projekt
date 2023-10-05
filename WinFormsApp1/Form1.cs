namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)

        {

        

        MessageBox.Show("Mitt första program", "meddelande",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }
    }
}