using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace telalogin
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            botao.Enabled = false;
            box2.PasswordChar = '*'; //deixa a senha invisivel
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = box1.Text.Length; //quantidade de caracter na caixa de texto
            int y = box2.TextLength;
            if (x == 0 && y == 0)
            {
                botao.Enabled = false;
                
            }
            else
            {
                botao.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "admin";
            string senha = "ds2025";
            if (box1.Text == login && box2.Text == senha)
            {
                MessageBox.Show("Login bem sucedido");
            }
            else
            {
                MessageBox.Show("Login ou senha incorreta");
            }
        }

        private void box2_TextChanged(object sender, EventArgs e)
        {
            int x = box1.Text.Length;
            int y = box2.TextLength;
            if (x == 0 && y == 0)
            {
                botao.Enabled = false;
                
            }
            else
            {
                botao.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                box2.PasswordChar = '\0'; //deixa a senha visivel
            }
            else
            {
                box2.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tela_de_cadastro homeForm = new tela_de_cadastro();
            homeForm.Show();
            this.Hide();
        }
    }
}
