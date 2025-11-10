using System.Xml;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int xix = 0;
        int win = 0;
        int win2 = 0;
        int win3 = 0;
        int win4 = 0;
        int win5 = 0;
        int win6 = 0;
        int win7 = 0;
        int win8 = 0;
        int win9 = 0;
        int pt1 = 0;
        int pt2 = 0;
        int impate = 0;
        int cor = 0;

        int modosolo = 0;
        string teste = "";



        public Form1()
        {
            InitializeComponent();
            xix = 0;
            win = 0;
            win2 = 0;
            win3 = 0;
            win4 = 0;
            win5 = 0;
            win6 = 0;
            win7 = 0;
            win8 = 0;
            win9 = 0;
            pt1 = 0;
            pt2 = 0;
            impate = 0;
            modosolo = 0;

            teste = "";
            pontos1.Text = "0";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xix = 0;
            win = 0;
            win2 = 0;
            win3 = 0;
            win4 = 0;
            win5 = 0;
            win6 = 0;
            win7 = 0;
            win8 = 0;
            win9 = 0;
            pt1 = 0;
            pt2 = 0;
            impate = 0;

            modosolo = 0;
            teste = "";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void action(object sender, EventArgs e)
        {
            if (xix == 0 && butt1.Text == "")
            {
                butt1.Text = "O";
                xix = 1;
                win = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt1.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt1.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt1.Text == "")
            {
                butt1.Text = "X";
                xix = 0;
                win = 0;
                comecou();
                if (cor == 2)
                {
                    butt1.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt1.ForeColor = Color.DarkRed;
                }

            }
            VerificarVencedor();
        }

        private void action2(object sender, EventArgs e)
        {
            if (xix == 0 && butt2.Text == "")
            {
                butt2.Text = "O";
                xix = 1;
                win2 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt2.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt2.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt2.Text == "")
            {
                butt2.Text = "X";
                xix = 0;
                win2 = 0;
                comecou();
                if (cor == 2)
                {
                    butt2.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt2.ForeColor = Color.DarkRed;
                }

            }
            VerificarVencedor();
        }

        private void action3(object sender, EventArgs e)
        {
            if (xix == 0 && butt3.Text == "")
            {
                butt3.Text = "O";
                xix = 1;
                win3 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt3.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt3.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt3.Text == "")
            {
                butt3.Text = "X";
                xix = 0;
                win3 = 0;
                comecou();
                if (cor == 2)
                {
                    butt3.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt3.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void action4(object sender, EventArgs e)
        {
            if (xix == 0 && butt4.Text == "")
            {
                butt4.Text = "O";
                xix = 1;
                win4 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt4.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt4.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt4.Text == "")
            {
                butt4.Text = "X";
                xix = 0;
                win4 = 0;
                comecou();
                if (cor == 2)
                {
                    butt4.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt4.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void action5(object sender, EventArgs e)
        {
            if (xix == 0 && butt5.Text == "")
            {
                butt5.Text = "O";
                xix = 1;
                win5 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt5.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt5.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt5.Text == "")
            {
                butt5.Text = "X";
                xix = 0;
                win5 = 0;
                comecou();
                if (cor == 2)
                {
                    butt5.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt5.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void action6(object sender, EventArgs e)
        {
            if (xix == 0 && butt6.Text == "")
            {
                butt6.Text = "O";
                xix = 1;
                win6 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt6.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt6.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt6.Text == "")
            {
                butt6.Text = "X";
                xix = 0;
                win6 = 0;
                comecou();
                if (cor == 2)
                {
                    butt6.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt6.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void action7(object sender, EventArgs e)
        {
            if (xix == 0 && butt7.Text == "")
            {
                butt7.Text = "O";
                xix = 1;
                win7 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt7.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt7.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt7.Text == "")
            {
                butt7.Text = "X";
                xix = 0;
                win7 = 0;
                comecou();
                if (cor == 2)
                {
                    butt7.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt7.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void action8(object sender, EventArgs e)
        {
            if (xix == 0 && butt8.Text == "")
            {
                butt8.Text = "O";
                xix = 1;
                win8 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt8.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt8.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt8.Text == "")
            {
                butt8.Text = "X";
                xix = 0;
                win8 = 0;
                comecou();
                if (cor == 2)
                {
                    butt8.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt8.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void action9(object sender, EventArgs e)
        {
            if (xix == 0 && butt9.Text == "")
            {
                butt9.Text = "O";
                xix = 1;
                win9 = 1;
                comecou();
                bot();
                if (cor == 1)
                {
                    butt9.ForeColor = Color.Blue;
                }
                if (cor == 2)
                {
                    butt9.ForeColor = Color.DarkRed;
                }
            }
            if (xix == 1 && butt9.Text == "")
            {
                butt9.Text = "X";
                xix = 0;
                win9 = 0;
                comecou();
                if (cor == 2)
                {
                    butt9.ForeColor = Color.Blue;
                }
                if (cor == 1)
                {
                    butt9.ForeColor = Color.DarkRed;
                }
            }
            VerificarVencedor();
        }

        private void empate_Click(object sender, EventArgs e)
        {

        }

        private void player1_Click(object sender, EventArgs e)
        {

        }

        private void nomezin1(object sender, EventArgs e)
        {
            player1.Text = n1.Text;
            tudocerto();
        }

        private void nomezin2(object sender, EventArgs e)
        {
            player2.Text = n2.Text;
            tudocerto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pontos1.Text = "0";
            pontos2.Text = "0";
            empate.Text = "0";
            butt1.Text = "";
            butt2.Text = "";
            butt3.Text = "";
            butt4.Text = "";
            butt5.Text = "";
            butt6.Text = "";
            butt7.Text = "";
            butt8.Text = "";
            butt9.Text = "";
            impate = 0;
            pt1 = 0;
            pt2 = 0;
            button2.Enabled = false;
            button2.BackColor = Color.Silver;
        }

        private void pontuação1(object sender, EventArgs e)
        {


        }

        private void pontos1_Click_1(object sender, EventArgs e)
        {

        }

        private void pontuação(object sender, ControlEventArgs e)
        {

        }


        private void Jogador1Venceu(object sender, EventArgs e)
        {

        }
        private void VerificarVencedor()
        {
            string vencedor = "";

            // Pontuação em linhas
            if (butt1.Text == butt2.Text && butt2.Text == butt3.Text && butt1.Text != "")
                vencedor = butt1.Text;
            else if (butt4.Text == butt5.Text && butt5.Text == butt6.Text && butt4.Text != "")
                vencedor = butt4.Text;
            else if (butt7.Text == butt8.Text && butt8.Text == butt9.Text && butt7.Text != "")
                vencedor = butt7.Text;
            // Pontuação em colunas
            else if (butt1.Text == butt4.Text && butt4.Text == butt7.Text && butt1.Text != "")
                vencedor = butt1.Text;
            else if (butt2.Text == butt5.Text && butt5.Text == butt8.Text && butt2.Text != "")
                vencedor = butt2.Text;
            else if (butt3.Text == butt6.Text && butt6.Text == butt9.Text && butt3.Text != "")
                vencedor = butt3.Text;
            // Pontuação em diagonais
            else if (butt1.Text == butt5.Text && butt5.Text == butt9.Text && butt1.Text != "")
                vencedor = butt1.Text;
            else if (butt3.Text == butt5.Text && butt5.Text == butt7.Text && butt3.Text != "")
                vencedor = butt3.Text;

            if (vencedor != "")
            {
                if (vencedor == "O")
                {
                    pt1++;
                    pontos1.Text = pt1.ToString();
                    MessageBox.Show(player1.Text + " venceu!");
                }
                else if (vencedor == "X")
                {
                    pt2++;
                    pontos2.Text = pt2.ToString();
                    MessageBox.Show(player2.Text + " venceu!");
                }

                resetar();
            }
            else if (TodasAsCasasPreenchidas())
            {
                MessageBox.Show("Empate!");
                impate++;
                empate.Text = impate.ToString();
                resetar();
            }
        }

        private bool TodasAsCasasPreenchidas()
        {
            return butt1.Text != "" && butt2.Text != "" && butt3.Text != "" &&
                   butt4.Text != "" && butt5.Text != "" && butt6.Text != "" &&
                   butt7.Text != "" && butt8.Text != "" && butt9.Text != "";
        }
        private void resetar()
        {
            butt1.Text = "";
            butt2.Text = "";
            butt3.Text = "";
            butt4.Text = "";
            butt5.Text = "";
            butt6.Text = "";
            butt7.Text = "";
            butt8.Text = "";
            butt9.Text = "";
            xix = 0;
        }

        private void pontuação2(object sender, EventArgs e)
        {

        }

        private void bolinha(object sender, EventArgs e)
        {
            if (op2.ForeColor == Color.Blue)
            {
                op1.ForeColor = Color.DarkRed;
                cor = 1;
                tudocerto();
            }
            if (op2.ForeColor == Color.DarkRed)
            {
                op1.ForeColor = Color.Blue;
                cor = 2;
                tudocerto();
            }
            else
                op1.ForeColor = Color.DarkRed;
            cor = 1;
            tudocerto();
        }

        private void X(object sender, EventArgs e)
        {
            if (op1.ForeColor == Color.Blue)
            {
                op2.ForeColor = Color.DarkRed;
                cor = 2;
                tudocerto();
            }
            if (op1.ForeColor == Color.DarkRed)
            {
                op2.ForeColor = Color.Blue;
                cor = 1;
                tudocerto();
            }
            else
                op2.ForeColor = Color.DarkRed;
            cor = 2;
            tudocerto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butt1.Enabled = true;
            butt2.Enabled = true;
            butt3.Enabled = true;
            butt4.Enabled = true;
            butt5.Enabled = true;
            butt6.Enabled = true;
            butt7.Enabled = true;
            butt8.Enabled = true;
            butt9.Enabled = true;
            butt1.BackColor = Color.Teal;
            butt2.BackColor = Color.Teal;
            butt3.BackColor = Color.Teal;
            butt4.BackColor = Color.Teal;
            butt5.BackColor = Color.Teal;
            butt6.BackColor = Color.Teal;
            butt7.BackColor = Color.Teal;
            butt8.BackColor = Color.Teal;
            butt9.BackColor = Color.Teal;
            button1.BackColor = Color.Silver;
            button1.Enabled = false;
        }
        private void comecou()
        {
            if (butt1.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt2.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt3.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt4.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt5.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt6.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt7.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt8.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
            if (butt9.Text != "")
            {
                button2.Enabled = true;
                button2.BackColor = Color.White;
            }
        }

        private void solo_Click(object sender, EventArgs e)
        {
            modosolo = 1;
            n2.Enabled = false;
            player2.Text = "Bot";
            Normal.Visible = true;
            Hard.Visible = true;
            op1.ForeColor = Color.Blue;
            op2.ForeColor = Color.DarkRed;
            button1.Enabled = false;
            button1.BackColor = Color.Silver;
            solo.Enabled = false;
            solo.BackColor = Color.Silver;
            cor = 1;
            impate = 0;
            pt1 = 0;
            pt2 = 0;
            butt1.Enabled = false;
            butt1.BackColor = Color.DarkSlateGray;
            butt2.Enabled = false;
            butt2.BackColor = Color.DarkSlateGray;
            butt3.Enabled = false;
            butt3.BackColor = Color.DarkSlateGray;
            butt4.Enabled = false;
            butt4.BackColor = Color.DarkSlateGray;
            butt5.Enabled = false;
            butt5.BackColor = Color.DarkSlateGray;
            butt6.Enabled = false;
            butt6.BackColor = Color.DarkSlateGray;
            butt7.Enabled = false;
            butt7.BackColor = Color.DarkSlateGray;
            butt8.Enabled = false;
            butt8.BackColor = Color.DarkSlateGray;
            butt9.Enabled = false;
            butt9.BackColor = Color.DarkSlateGray;
            resetar();
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            Normal.ForeColor = Color.DarkRed;
            Hard.ForeColor = Color.Teal;
            button1.Enabled = true;
            button1.BackColor = Color.White;
            impate = 0;
            pt1 = 0;
            pt2 = 0;
            butt1.Enabled = false;
            butt1.BackColor = Color.DarkSlateGray;
            butt2.Enabled = false;
            butt2.BackColor = Color.DarkSlateGray;
            butt3.Enabled = false;
            butt3.BackColor = Color.DarkSlateGray;
            butt4.Enabled = false;
            butt4.BackColor = Color.DarkSlateGray;
            butt5.Enabled = false;
            butt5.BackColor = Color.DarkSlateGray;
            butt6.Enabled = false;
            butt6.BackColor = Color.DarkSlateGray;
            butt7.Enabled = false;
            butt7.BackColor = Color.DarkSlateGray;
            butt8.Enabled = false;
            butt8.BackColor = Color.DarkSlateGray;
            butt9.Enabled = false;
            butt9.BackColor = Color.DarkSlateGray;
            resetar();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Hard.ForeColor = Color.DarkRed;
            Normal.ForeColor = Color.Teal;
            button1.Enabled = true;
            button1.BackColor = Color.White;
            impate = 0;
            pt1 = 0;
            pt2 = 0;
            butt1.Enabled = false;
            butt1.BackColor = Color.DarkSlateGray;
            butt2.Enabled = false;
            butt2.BackColor = Color.DarkSlateGray;
            butt3.Enabled = false;
            butt3.BackColor = Color.DarkSlateGray;
            butt4.Enabled = false;
            butt4.BackColor = Color.DarkSlateGray;
            butt5.Enabled = false;
            butt5.BackColor = Color.DarkSlateGray;
            butt6.Enabled = false;
            butt6.BackColor = Color.DarkSlateGray;
            butt7.Enabled = false;
            butt7.BackColor = Color.DarkSlateGray;
            butt8.Enabled = false;
            butt8.BackColor = Color.DarkSlateGray;
            butt9.Enabled = false;
            butt9.BackColor = Color.DarkSlateGray;
            resetar();
        }
        private void tudocerto()
        {
            if (op1.ForeColor != Color.White && op2.ForeColor != Color.White && n1.Text != "" && n2.Text != "")
            {
                button1.Enabled = true;
                button1.BackColor = Color.White;
            }
        }
        private void bot()
        {
                Random random = new Random();
                int numeroAleatorio = random.Next(0,9);
            if (numeroAleatorio == 0 && butt1.Text == "")
            {
                butt1.Text = "X";
                butt1.ForeColor = Color.DarkRed;
                xix = 0;
            }
                if (numeroAleatorio == 1 && butt2.Text == "")
                {
                    butt2.Text = "X";
                    butt2.ForeColor = Color.DarkRed;
                    xix = 0;
                }
            if (numeroAleatorio == 2 && butt3.Text == "")
                {
                    butt3.Text = "X";
                    butt3.ForeColor = Color.DarkRed;
                    xix = 0;
                }

                if (numeroAleatorio == 3 && butt4.Text == "")
                {
                    butt4.Text = "X";
                    butt4.ForeColor = Color.DarkRed;
                    xix = 0;
                }
                if (numeroAleatorio == 4 && butt5.Text == "")
                {
                    butt5.Text = "X";
                    butt5.ForeColor = Color.DarkRed;
                    xix = 0;
                }
                if (numeroAleatorio == 5 && butt6.Text == "")
                {
                    butt6.Text = "X";
                    butt6.ForeColor = Color.DarkRed;
                    xix = 0;
                }
                if (numeroAleatorio == 6 && butt7.Text == "")
                {
                    butt7.Text = "X";
                    butt7.ForeColor = Color.DarkRed;
                    xix = 0;
                }
                if (numeroAleatorio == 7 && butt8.Text == "")
                {
                    butt8.Text = "X";
                    butt8.ForeColor = Color.DarkRed;
                    xix = 0;
                }
                if (numeroAleatorio == 8 && butt9.Text == "")
                {
                    butt9.Text = "X";
                    butt9.ForeColor = Color.DarkRed;
                    xix = 0;
                }
        }
    }
}