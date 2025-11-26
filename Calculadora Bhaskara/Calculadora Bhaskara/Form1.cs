using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Bhaskara
{
    public partial class Form1 : Form
    {
        int select = 0;
        double A;
        double B;
        double C;
        double Delta;
        public Form1()
        {
            InitializeComponent();
            select = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            txtA.BackColor = Color.Yellow;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtA.BackColor = Color.Yellow;
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtA_Click(object sender, EventArgs e)
        {
            txtA.BackColor = Color.Yellow;
            txtB.BackColor = Color.White;
            txtC.BackColor = Color.White;
            select = 1;
        }

        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.BackColor = Color.Yellow;
            txtA.BackColor = Color.White;
            txtC.BackColor = Color.White;
            select = 2;
        }

        private void txtC_Click(object sender, EventArgs e)
        {
            txtC.BackColor = Color.Yellow;
            txtB.BackColor = Color.White;
            txtA.BackColor = Color.White;
            select = 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn0.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn0.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn0.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn1.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn1.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn2.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn2.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn3.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn3.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn4.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn4.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn5.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn5.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn6.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn6.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn7.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn7.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn8.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn8.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += btn9.Text;
            }
            else if (select == 2)
            {
                txtB.Text += btn9.Text;
            }
            else if (select == 3)
            {
                txtC.Text += btn9.Text;
            }
        }

        private void negativo_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text += negativo.Text;
            }
            else if (select == 2)
            {
                txtB.Text += negativo.Text;
            }
            else if (select == 3)
            {
                txtC.Text += negativo.Text;
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                txtA.Text = String.Empty;
            }
            else if (select == 2)
            {
                txtB.Text = String.Empty;
            }
            else if (select == 3)
            {
                txtC.Text = String.Empty;

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Text = String.Empty;
            txtB.Text = String.Empty;
            txtC.Text = String.Empty;
            txtResultado.Text = String.Empty;
            txtX1.Text = String.Empty;
            txtX2.Text = String.Empty;
            txtB.BackColor = Color.White;
            txtA.BackColor = Color.White;
            txtC.BackColor = Color.White;
            select = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtA.Text == String.Empty)
            {
                MessageBox.Show("Não há valor na caixa");
            }
            else if (txtB.Text == String.Empty)
            {
                MessageBox.Show("Não há valor na caixa");
            }
            else if (txtC.Text == String.Empty)
            {
                MessageBox.Show("Não há valor na caixa");
            }
            else
            {
                A = double.Parse(txtA.Text);
                B = double.Parse(txtB.Text);
                C = double.Parse(txtC.Text);

                Delta = (B * B) - (4 * A * C);

                if (Delta < 0)
                {
                    MessageBox.Show("O resultado dele é negativo");
                    txtResultado.Text = Delta.ToString();
                    txtX1.Text = "NÃO TEM";
                    txtX2.Text = "NÃO TEM";
                }
                else
                {
                    txtResultado.Text = Delta.ToString();

                    double X1 = -B + (Math.Sqrt(Delta)) / (2 * A);
                    double X2 = -B - (Math.Sqrt(Delta)) / (2 * A);

                    txtX1.Text = X1.ToString();
                    txtX2.Text = X2.ToString();
                }
            
            }
        }

        private void btnHistórico_Click(object sender, EventArgs e)
        {
            listHistorico.Items.Add("Delta = B² - 4 x A x C");
            listHistorico.Items.Add($"Delta = ({B})² - 4 x {A} x {C}");
            listHistorico.Items.Add($"Delta = {Delta}");
            listHistorico.Items.Add("-----------------------------------------");
        }
    }
}
