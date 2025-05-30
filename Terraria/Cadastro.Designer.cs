namespace JogoTerraria
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblUser = new Label();
            lblTipo = new Label();
            lblNvl = new Label();
            lblRaca = new Label();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            btnImagem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 211, 179);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(62, 44, 27);
            textBox1.Location = new Point(249, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 211, 179);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(62, 44, 27);
            textBox2.Location = new Point(249, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(230, 211, 179);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = Color.FromArgb(62, 44, 27);
            textBox3.Location = new Point(249, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(230, 211, 179);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.ForeColor = Color.FromArgb(62, 44, 27);
            textBox4.Location = new Point(249, 392);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 15F);
            lblUser.ForeColor = Color.Gold;
            lblUser.Location = new Point(249, 191);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(103, 28);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Segoe UI", 15F);
            lblTipo.ForeColor = Color.Gold;
            lblTipo.Location = new Point(249, 248);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(69, 28);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Classe:";
            // 
            // lblNvl
            // 
            lblNvl.AutoSize = true;
            lblNvl.BackColor = Color.Transparent;
            lblNvl.Font = new Font("Segoe UI", 15F);
            lblNvl.ForeColor = Color.Gold;
            lblNvl.Location = new Point(249, 304);
            lblNvl.Name = "lblNvl";
            lblNvl.Size = new Size(61, 28);
            lblNvl.TabIndex = 6;
            lblNvl.Text = "Nível:";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.BackColor = Color.Transparent;
            lblRaca.Font = new Font("Segoe UI", 15F);
            lblRaca.ForeColor = Color.Gold;
            lblRaca.Location = new Point(249, 361);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(57, 28);
            lblRaca.TabIndex = 7;
            lblRaca.Text = "Raça:";
            lblRaca.Click += lblRaca_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(201, 99, 52);
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(229, 122, 72);
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 122, 72);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 122, 72);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(222, 439);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(255, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(471, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 136);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnImagem
            // 
            btnImagem.BackColor = Color.FromArgb(201, 99, 52);
            btnImagem.FlatAppearance.BorderColor = Color.FromArgb(229, 122, 72);
            btnImagem.FlatAppearance.BorderSize = 0;
            btnImagem.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 122, 72);
            btnImagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 122, 72);
            btnImagem.FlatStyle = FlatStyle.Flat;
            btnImagem.ForeColor = Color.White;
            btnImagem.Location = new Point(484, 368);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(75, 23);
            btnImagem.TabIndex = 10;
            btnImagem.Text = "Imagem";
            btnImagem.UseVisualStyleBackColor = false;
            btnImagem.Click += btnImagem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(496, 439);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 11;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 530);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnImagem);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(lblRaca);
            Controls.Add(textBox2);
            Controls.Add(lblNvl);
            Controls.Add(lblTipo);
            Controls.Add(textBox1);
            Controls.Add(lblUser);
            Name = "Cadastro";
            ShowIcon = false;
            Text = "Form1";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblUser;
        private Label lblTipo;
        private Label lblNvl;
        private Label lblRaca;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Button btnImagem;
        private Button button1;
    }
}
