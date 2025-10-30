namespace Miku_Lanches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (CheckH.Checked == true)
            {
                numH.Enabled = true;
                numH.Text = "1";
                total1.Enabled = true;
            }
            else
            {
                numH.Enabled = false;
                numH.Text = "0";
                total1.Enabled = false;
                total1.Text = "0,00";
            }
        }

        private void numH_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void total3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pi(object sender, EventArgs e)
        {
            if (CheckP.Checked == true)
            {
                NUMTO.Enabled = true;
                NUMTO.Text = "1";
                total2.Enabled = true;
            }
            else
            {
                NUMTO.Enabled = false;
                NUMTO.Text = "0";
                total2.Enabled = false;
                total2.Text = "0,00";
            }
        }

        private void TO(object sender, EventArgs e)
        {
            if (CheckT.Checked == true)
            {
                numT.Enabled = true;
                numT.Text = "1";
                total3.Enabled = true;
            }
            else
            {
                numT.Enabled = false;
                numT.Text = "0";
                total3.Enabled = false;
                total3.Text = "0,00";
            }
        }
    }
}