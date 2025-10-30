namespace Miku_Lanches
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
            numP = new GroupBox();
            total3 = new TextBox();
            total2 = new TextBox();
            preço3 = new TextBox();
            preço2 = new TextBox();
            numT = new NumericUpDown();
            NUMTO = new NumericUpDown();
            CheckT = new CheckBox();
            CheckP = new CheckBox();
            total1 = new TextBox();
            preço1 = new TextBox();
            CheckH = new CheckBox();
            numH = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            numP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUMTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numH).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // numP
            // 
            numP.Controls.Add(total3);
            numP.Controls.Add(total2);
            numP.Controls.Add(preço3);
            numP.Controls.Add(preço2);
            numP.Controls.Add(numT);
            numP.Controls.Add(NUMTO);
            numP.Controls.Add(CheckT);
            numP.Controls.Add(CheckP);
            numP.Controls.Add(total1);
            numP.Controls.Add(preço1);
            numP.Controls.Add(CheckH);
            numP.Controls.Add(numH);
            numP.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numP.ForeColor = SystemColors.Window;
            numP.Location = new Point(12, 237);
            numP.Name = "numP";
            numP.Size = new Size(382, 353);
            numP.TabIndex = 0;
            numP.TabStop = false;
            numP.Text = "Ingredienets";
            // 
            // total3
            // 
            total3.Enabled = false;
            total3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total3.Location = new Point(288, 127);
            total3.Name = "total3";
            total3.RightToLeft = RightToLeft.Yes;
            total3.Size = new Size(76, 25);
            total3.TabIndex = 14;
            total3.Text = "0,00";
            total3.Click += checkBox1_Click;
            total3.TextChanged += total3_TextChanged;
            // 
            // total2
            // 
            total2.Enabled = false;
            total2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total2.Location = new Point(288, 91);
            total2.Name = "total2";
            total2.RightToLeft = RightToLeft.Yes;
            total2.Size = new Size(76, 25);
            total2.TabIndex = 13;
            total2.Text = "0,00";
            total2.Click += checkBox1_Click;
            // 
            // preço3
            // 
            preço3.Enabled = false;
            preço3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            preço3.Location = new Point(188, 128);
            preço3.Name = "preço3";
            preço3.RightToLeft = RightToLeft.Yes;
            preço3.Size = new Size(76, 25);
            preço3.TabIndex = 12;
            preço3.Text = "2,00";
            preço3.Click += checkBox1_Click;
            // 
            // preço2
            // 
            preço2.Enabled = false;
            preço2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            preço2.Location = new Point(188, 92);
            preço2.Name = "preço2";
            preço2.RightToLeft = RightToLeft.Yes;
            preço2.Size = new Size(76, 25);
            preço2.TabIndex = 11;
            preço2.Text = "2,00";
            preço2.Click += checkBox1_Click;
            // 
            // numT
            // 
            numT.Enabled = false;
            numT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numT.Location = new Point(122, 128);
            numT.Name = "numT";
            numT.Size = new Size(43, 25);
            numT.TabIndex = 10;
            numT.Click += checkBox1_Click;
            // 
            // NUMTO
            // 
            NUMTO.Enabled = false;
            NUMTO.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NUMTO.Location = new Point(122, 91);
            NUMTO.Name = "NUMTO";
            NUMTO.Size = new Size(43, 25);
            NUMTO.TabIndex = 9;
            NUMTO.Click += checkBox1_Click;
            // 
            // CheckT
            // 
            CheckT.AutoSize = true;
            CheckT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckT.Location = new Point(15, 129);
            CheckT.Name = "CheckT";
            CheckT.Size = new Size(70, 21);
            CheckT.TabIndex = 8;
            CheckT.Text = "Tomate";
            CheckT.UseVisualStyleBackColor = true;
            CheckT.Click += TO;
            // 
            // CheckP
            // 
            CheckP.AutoSize = true;
            CheckP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckP.Location = new Point(15, 92);
            CheckP.Name = "CheckP";
            CheckP.Size = new Size(59, 21);
            CheckP.TabIndex = 7;
            CheckP.Text = "Picles";
            CheckP.UseVisualStyleBackColor = true;
            CheckP.Click += pi;
            // 
            // total1
            // 
            total1.Enabled = false;
            total1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total1.Location = new Point(288, 55);
            total1.Name = "total1";
            total1.RightToLeft = RightToLeft.Yes;
            total1.Size = new Size(76, 25);
            total1.TabIndex = 6;
            total1.Text = "0,00";
            total1.Click += checkBox1_Click;
            // 
            // preço1
            // 
            preço1.Enabled = false;
            preço1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            preço1.Location = new Point(188, 55);
            preço1.Name = "preço1";
            preço1.RightToLeft = RightToLeft.Yes;
            preço1.Size = new Size(76, 25);
            preço1.TabIndex = 5;
            preço1.Text = "2,00";
            preço1.Click += checkBox1_Click;
            // 
            // CheckH
            // 
            CheckH.AutoSize = true;
            CheckH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckH.Location = new Point(15, 55);
            CheckH.Name = "CheckH";
            CheckH.Size = new Size(101, 21);
            CheckH.TabIndex = 0;
            CheckH.Text = "Hamburguer";
            CheckH.UseVisualStyleBackColor = true;
            CheckH.Click += checkBox1_Click;
            // 
            // numH
            // 
            numH.Enabled = false;
            numH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numH.Location = new Point(122, 54);
            numH.Name = "numH";
            numH.Size = new Size(43, 25);
            numH.TabIndex = 4;
            numH.Click += checkBox1_Click;
            numH.ControlAdded += numH_ControlAdded;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 211);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(233, 12);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 2;
            label2.Text = "MIKU LANCHES";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(17, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(342, 228);
            listBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Window;
            groupBox2.Location = new Point(408, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 353);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pedido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(804, 707);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numP);
            Name = "Form1";
            Text = "Form1";
            numP.ResumeLayout(false);
            numP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numT).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUMTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)numH).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox numP;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private NumericUpDown numH;
        private TextBox total1;
        private TextBox preço1;
        private CheckBox CheckH;
        private GroupBox groupBox2;
        private NumericUpDown numT;
        private NumericUpDown NUMTO;
        private CheckBox CheckT;
        private CheckBox CheckP;
        private TextBox total3;
        private TextBox total2;
        private TextBox preço3;
        private TextBox preço2;
    }
}