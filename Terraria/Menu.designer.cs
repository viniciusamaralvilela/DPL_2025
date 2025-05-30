namespace JogoTerraria
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnCadastre = new Button();
            btnTenho = new Button();
            pictureBox1 = new PictureBox();
            btnConfirmar = new Button();
            lblDigite = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastre
            // 
            btnCadastre.BackColor = SystemColors.ActiveCaption;
            btnCadastre.FlatAppearance.BorderSize = 0;
            btnCadastre.FlatStyle = FlatStyle.Flat;
            btnCadastre.Location = new Point(312, 213);
            btnCadastre.Name = "btnCadastre";
            btnCadastre.Size = new Size(152, 40);
            btnCadastre.TabIndex = 1;
            btnCadastre.Text = "Cadastre-se";
            btnCadastre.UseVisualStyleBackColor = false;
            btnCadastre.Click += btnCadastre_Click;
            // 
            // btnTenho
            // 
            btnTenho.BackColor = Color.LightGreen;
            btnTenho.FlatAppearance.BorderSize = 0;
            btnTenho.FlatStyle = FlatStyle.Flat;
            btnTenho.Location = new Point(312, 259);
            btnTenho.Name = "btnTenho";
            btnTenho.Size = new Size(152, 41);
            btnTenho.TabIndex = 2;
            btnTenho.Text = "Já tenho personagem";
            btnTenho.UseVisualStyleBackColor = false;
            btnTenho.Click += btnTenho_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(242, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 82);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.LightGreen;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(334, 242);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(111, 27);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblDigite
            // 
            lblDigite.AutoSize = true;
            lblDigite.BackColor = Color.Transparent;
            lblDigite.Location = new Point(288, 195);
            lblDigite.Name = "lblDigite";
            lblDigite.Size = new Size(192, 15);
            lblDigite.TabIndex = 5;
            lblDigite.Text = "Digite o nome do seu personagem:";
            lblDigite.Visible = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(288, 213);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(215, 23);
            txtNome.TabIndex = 6;
            txtNome.Visible = false;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(334, 415);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 7;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(346, 340);
            button2.Name = "button2";
            button2.Size = new Size(89, 36);
            button2.TabIndex = 8;
            button2.Text = "Achar arquivo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 530);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(lblDigite);
            Controls.Add(btnConfirmar);
            Controls.Add(pictureBox1);
            Controls.Add(btnTenho);
            Controls.Add(btnCadastre);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastre;
        private Button btnTenho;
        private PictureBox pictureBox1;
        private Button btnConfirmar;
        private Label lblDigite;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
    }
}