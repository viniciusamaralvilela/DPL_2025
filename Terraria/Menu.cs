using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoTerraria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
        }
        private void btnCadastre_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }
        private void btnTenho_Click_1(object sender, EventArgs e)
        {

            btnCadastre.Visible = false;
            btnTenho.Visible = false;
            btnConfirmar.Visible = true;
            lblDigite.Visible = true;
            txtNome.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string achar = txtNome.Text;
            personagem buscar = new personagem();
            if (achar != buscar.getNome())
            {
                MessageBox.Show("Personagem não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Exibir exibir = new Exibir(buscar.getNome(), buscar.getClasse(), buscar.getNivel(), buscar.getRaca(), buscar.getImagem());
                exibir.Show();
                this.Hide();
            }

            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCadastre.Visible = true;
            btnTenho.Visible = true;
            btnConfirmar.Visible = false;
            lblDigite.Visible = false;
            txtNome.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Aqruivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            openFileDialog.Title = "Abrir Arquivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    string conteudo = reader.ReadToEnd();
                    string[] partes = conteudo.Split(';');
                    if (partes.Length >= 4)
                    {
                        string nome = partes[0];
                        string classe = partes[1];
                        int nivel = int.Parse(partes[2]);
                        string raca = partes[3];
                        Image imagem = null;
                        string caminhoImagem = Path.ChangeExtension(caminhoArquivo, ".png");
                        if (File.Exists(caminhoImagem))
                        {
                            imagem = Image.FromFile(caminhoImagem);
                        }
                        Exibir exibir = new Exibir(nome, classe, nivel, raca, imagem);
                        exibir.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Formato de arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
