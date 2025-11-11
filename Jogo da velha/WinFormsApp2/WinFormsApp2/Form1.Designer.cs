namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            n2 = new TextBox();
            n1 = new TextBox();
            groupBox2 = new GroupBox();
            empate = new Label();
            groupBox3 = new GroupBox();
            pontos2 = new Label();
            pontos1 = new Label();
            player2 = new Label();
            player1 = new Label();
            groupBox4 = new GroupBox();
            op2 = new Label();
            op1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            butt1 = new Button();
            butt7 = new Button();
            butt4 = new Button();
            butt9 = new Button();
            butt6 = new Button();
            butt3 = new Button();
            butt2 = new Button();
            butt5 = new Button();
            butt8 = new Button();
            richTextBox1 = new RichTextBox();
            solo = new Button();
            Normal = new Button();
            Hard = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(n2);
            groupBox1.Controls.Add(n1);
            groupBox1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogadores";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // n2
            // 
            n2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n2.BackColor = Color.DarkRed;
            n2.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            n2.Location = new Point(6, 50);
            n2.Name = "n2";
            n2.PlaceholderText = "Player 2";
            n2.Size = new Size(188, 25);
            n2.TabIndex = 1;
            n2.TextChanged += nomezin2;
            // 
            // n1
            // 
            n1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n1.BackColor = Color.Blue;
            n1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            n1.Location = new Point(6, 21);
            n1.Name = "n1";
            n1.PlaceholderText = "Player 1";
            n1.Size = new Size(188, 25);
            n1.TabIndex = 0;
            n1.TextChanged += nomezin1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(empate);
            groupBox2.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(424, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(123, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Empate";
            // 
            // empate
            // 
            empate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            empate.AutoSize = true;
            empate.Font = new Font("Bauhaus 93", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            empate.Location = new Point(36, 20);
            empate.Name = "empate";
            empate.Size = new Size(50, 53);
            empate.TabIndex = 0;
            empate.Text = "0";
            empate.Click += empate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(pontos2);
            groupBox3.Controls.Add(pontos1);
            groupBox3.Controls.Add(player2);
            groupBox3.Controls.Add(player1);
            groupBox3.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(218, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 82);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Placar";
            // 
            // pontos2
            // 
            pontos2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pontos2.AutoSize = true;
            pontos2.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            pontos2.Location = new Point(116, 38);
            pontos2.Name = "pontos2";
            pontos2.Size = new Size(28, 30);
            pontos2.TabIndex = 3;
            pontos2.Text = "0";
            pontos2.TextChanged += pontuação2;
            // 
            // pontos1
            // 
            pontos1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pontos1.AutoSize = true;
            pontos1.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            pontos1.Location = new Point(13, 38);
            pontos1.Name = "pontos1";
            pontos1.Size = new Size(28, 30);
            pontos1.TabIndex = 2;
            pontos1.Text = "0";
            pontos1.TextChanged += pontuação1;
            pontos1.Click += pontos1_Click;
            // 
            // player2
            // 
            player2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            player2.AutoSize = true;
            player2.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            player2.Location = new Point(116, 22);
            player2.Name = "player2";
            player2.Size = new Size(10, 14);
            player2.TabIndex = 1;
            player2.Text = "-";
            // 
            // player1
            // 
            player1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            player1.AutoSize = true;
            player1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            player1.Location = new Point(17, 22);
            player1.Name = "player1";
            player1.Size = new Size(10, 14);
            player1.TabIndex = 0;
            player1.Text = "-";
            player1.Click += player1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(op2);
            groupBox4.Controls.Add(op1);
            groupBox4.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(12, 100);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(104, 59);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opções";
            // 
            // op2
            // 
            op2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            op2.AutoSize = true;
            op2.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            op2.ForeColor = Color.White;
            op2.Location = new Point(55, 19);
            op2.Name = "op2";
            op2.Size = new Size(46, 28);
            op2.TabIndex = 33;
            op2.Text = "• X";
            op2.Click += X;
            // 
            // op1
            // 
            op1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            op1.AutoSize = true;
            op1.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            op1.ForeColor = Color.White;
            op1.Location = new Point(6, 19);
            op1.Name = "op1";
            op1.Size = new Size(52, 28);
            op1.TabIndex = 3;
            op1.Text = "• O";
            op1.Click += bolinha;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(218, 136);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 2;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Silver;
            button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(334, 136);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 3;
            button2.Text = "Reiniciar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = SystemColors.Window;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Teal;
            button3.Location = new Point(451, 136);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 4;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // butt1
            // 
            butt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt1.BackColor = Color.DarkSlateGray;
            butt1.Enabled = false;
            butt1.FlatAppearance.BorderSize = 0;
            butt1.FlatStyle = FlatStyle.Flat;
            butt1.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt1.ForeColor = Color.White;
            butt1.Location = new Point(172, 189);
            butt1.Name = "butt1";
            butt1.Size = new Size(75, 50);
            butt1.TabIndex = 22;
            butt1.UseVisualStyleBackColor = false;
            butt1.Click += action;
            // 
            // butt7
            // 
            butt7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt7.BackColor = Color.DarkSlateGray;
            butt7.Enabled = false;
            butt7.FlatAppearance.BorderSize = 0;
            butt7.FlatStyle = FlatStyle.Flat;
            butt7.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt7.ForeColor = Color.White;
            butt7.Location = new Point(172, 301);
            butt7.Name = "butt7";
            butt7.Size = new Size(75, 50);
            butt7.TabIndex = 25;
            butt7.UseVisualStyleBackColor = false;
            butt7.Click += action7;
            // 
            // butt4
            // 
            butt4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt4.BackColor = Color.DarkSlateGray;
            butt4.Enabled = false;
            butt4.FlatAppearance.BorderSize = 0;
            butt4.FlatStyle = FlatStyle.Flat;
            butt4.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt4.ForeColor = Color.White;
            butt4.Location = new Point(172, 245);
            butt4.Name = "butt4";
            butt4.Size = new Size(75, 50);
            butt4.TabIndex = 26;
            butt4.UseVisualStyleBackColor = false;
            butt4.Click += action4;
            // 
            // butt9
            // 
            butt9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt9.BackColor = Color.DarkSlateGray;
            butt9.Enabled = false;
            butt9.FlatAppearance.BorderSize = 0;
            butt9.FlatStyle = FlatStyle.Flat;
            butt9.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt9.ForeColor = Color.White;
            butt9.Location = new Point(334, 301);
            butt9.Name = "butt9";
            butt9.Size = new Size(75, 50);
            butt9.TabIndex = 27;
            butt9.UseVisualStyleBackColor = false;
            butt9.Click += action9;
            // 
            // butt6
            // 
            butt6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt6.BackColor = Color.DarkSlateGray;
            butt6.Enabled = false;
            butt6.FlatAppearance.BorderSize = 0;
            butt6.FlatStyle = FlatStyle.Flat;
            butt6.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt6.ForeColor = Color.White;
            butt6.Location = new Point(334, 245);
            butt6.Name = "butt6";
            butt6.Size = new Size(75, 50);
            butt6.TabIndex = 28;
            butt6.UseVisualStyleBackColor = false;
            butt6.Click += action6;
            // 
            // butt3
            // 
            butt3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt3.BackColor = Color.DarkSlateGray;
            butt3.Enabled = false;
            butt3.FlatAppearance.BorderSize = 0;
            butt3.FlatStyle = FlatStyle.Flat;
            butt3.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt3.ForeColor = Color.White;
            butt3.Location = new Point(334, 189);
            butt3.Name = "butt3";
            butt3.Size = new Size(75, 50);
            butt3.TabIndex = 29;
            butt3.UseVisualStyleBackColor = false;
            butt3.Click += action3;
            // 
            // butt2
            // 
            butt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt2.BackColor = Color.DarkSlateGray;
            butt2.Enabled = false;
            butt2.FlatAppearance.BorderSize = 0;
            butt2.FlatStyle = FlatStyle.Flat;
            butt2.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt2.ForeColor = Color.White;
            butt2.Location = new Point(253, 189);
            butt2.Name = "butt2";
            butt2.Size = new Size(75, 50);
            butt2.TabIndex = 30;
            butt2.UseVisualStyleBackColor = false;
            butt2.Click += action2;
            // 
            // butt5
            // 
            butt5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt5.BackColor = Color.DarkSlateGray;
            butt5.Enabled = false;
            butt5.FlatAppearance.BorderSize = 0;
            butt5.FlatStyle = FlatStyle.Flat;
            butt5.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt5.ForeColor = Color.White;
            butt5.Location = new Point(253, 245);
            butt5.Name = "butt5";
            butt5.Size = new Size(75, 50);
            butt5.TabIndex = 31;
            butt5.UseVisualStyleBackColor = false;
            butt5.Click += action5;
            // 
            // butt8
            // 
            butt8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butt8.BackColor = Color.DarkSlateGray;
            butt8.Enabled = false;
            butt8.FlatAppearance.BorderSize = 0;
            butt8.FlatStyle = FlatStyle.Flat;
            butt8.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            butt8.ForeColor = Color.White;
            butt8.Location = new Point(253, 301);
            butt8.Name = "butt8";
            butt8.Size = new Size(75, 50);
            butt8.TabIndex = 32;
            butt8.UseVisualStyleBackColor = false;
            butt8.Click += action8;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(-1, 165);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(583, 200);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // solo
            // 
            solo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            solo.BackColor = Color.White;
            solo.FlatAppearance.BorderSize = 0;
            solo.FlatStyle = FlatStyle.Popup;
            solo.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            solo.ForeColor = Color.Teal;
            solo.Location = new Point(18, 189);
            solo.Name = "solo";
            solo.Size = new Size(106, 30);
            solo.TabIndex = 33;
            solo.Text = "Jogar solo";
            solo.UseVisualStyleBackColor = false;
            solo.Click += solo_Click;
            // 
            // Normal
            // 
            Normal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Normal.BackColor = Color.White;
            Normal.FlatAppearance.BorderSize = 0;
            Normal.FlatStyle = FlatStyle.Popup;
            Normal.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Normal.ForeColor = Color.Teal;
            Normal.Location = new Point(18, 245);
            Normal.Name = "Normal";
            Normal.Size = new Size(106, 30);
            Normal.TabIndex = 34;
            Normal.Text = "Modo normal";
            Normal.UseVisualStyleBackColor = false;
            Normal.Visible = false;
            Normal.Click += Normal_Click;
            // 
            // Hard
            // 
            Hard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Hard.BackColor = Color.White;
            Hard.FlatAppearance.BorderSize = 0;
            Hard.FlatStyle = FlatStyle.Popup;
            Hard.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Hard.ForeColor = Color.Teal;
            Hard.Location = new Point(18, 281);
            Hard.Name = "Hard";
            Hard.Size = new Size(106, 30);
            Hard.TabIndex = 35;
            Hard.Text = "Modo difícil";
            Hard.UseVisualStyleBackColor = false;
            Hard.Visible = false;
            Hard.Click += Hard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(581, 365);
            Controls.Add(Hard);
            Controls.Add(Normal);
            Controls.Add(solo);
            Controls.Add(butt8);
            Controls.Add(butt5);
            Controls.Add(butt2);
            Controls.Add(butt3);
            Controls.Add(butt6);
            Controls.Add(butt9);
            Controls.Add(butt4);
            Controls.Add(butt7);
            Controls.Add(butt1);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Jogo da velha";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button butt1;
        private Button butt7;
        private Button butt4;
        private Button butt9;
        private Button butt6;
        private Button butt3;
        private Button butt2;
        private Button butt5;
        private Button butt8;
        private TextBox n2;
        private TextBox n1;
        private Label empate;
        private RichTextBox richTextBox1;
        private Label player1;
        private Label player2;
        private Label pontos2;
        private Label pontos1;
        private Label op1;
        private Label op2;
        private Button solo;
        private Button Normal;
        private Button Hard;
    }
}