using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Para usar o File.WriteAllText

namespace telalogin
{
    public partial class tela_de_cadastro: Form
    {
        public tela_de_cadastro()
        {
            InitializeComponent();
            txt2.PasswordChar = '*';
            button.Enabled = false;
        }

        private void tela_de_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt2.PasswordChar = '\0';
            }
            else
            {
                txt2.PasswordChar = '*';
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string caminho = "dados.txt1";
            string usuario = txt1.Text;

            try //garantir que, caso ocorra algum erro durante o processo de salvar o arquivo (por exemplo, se o arquivo não puder ser gravado devido a permissões, ou se o caminho estiver incorreto), o programa não "quebrasse" de forma inesperada.
            {
                File.WriteAllText(caminho, usuario); //O file facilita a manipulção de arquivos dentro do programa, e nesse caso ele escreve um texto em um arquivo
                MessageBox.Show("Conta salva");
            }
            catch //Ele é utilizado para capturar e tratar erros que ocorrem dentro de um bloco try
            {
                MessageBox.Show("Erro ao salvar o arquivo");
            }
            
            string caminho2 = "dados.txt2";
            string senha = txt2.Text;

            try 
            {
                File.WriteAllText(caminho2, senha);
                MessageBox.Show("Conta salva");
            }
            catch 
            {
                MessageBox.Show("Erro ao salvar o arquivo");
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            int z = txt1.Text.Length;
            int a = txt2.Text.Length;
            if (a == 0 && z == 0)
            {
                button.Enabled = false;
            }
            else
            {
                button.Enabled = true;
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            int z = txt1.Text.Length;
            int a = txt2.Text.Length;
            if (a == 0 && z == 0)
            {
                button.Enabled = false;
            }
            else
            {
                button.Enabled = true;
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1(); //form1 é a classe da primeira tela, e voltar é como u vou chama-la. O new form1 cria um objeto na memoria
            voltar.Show();
            this.Hide();
        }
    }
}
