using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace JogoTerraria
{
    public partial class editar : Form
    {
        public editar(string nome, string classe, int nivel, string raca, System.Drawing.Image image)
        {
            InitializeComponent();
            label1.Text = nome;
            label2.Text = classe;
            label3.Text = nivel.ToString();
            label4.Text = raca;
            if (image != null)
            {
                pictureBox1.Image = new Bitmap(image); // Cria cópia em memória
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Para evitar distorção
            }
            button3.Enabled = false; // Desabilita o botão de editar até que os campos sejam preenchidos
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personagem back2 = new personagem();

            back2.setNome(textBox1.Text);
            string nome = back2.getNome();

            back2.setClasse(textBox2.Text);
            string classe = back2.getClasse();

            int converter = int.Parse(textBox3.Text);
            if (converter < 1 || converter > 100)
            {
                MessageBox.Show("Nível inválido. Deve estar entre 1 e 100.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            back2.setNivel(converter);
            int nivel = back2.getNivel();

            back2.setRaca(textBox4.Text);
            string raca = back2.getRaca();

            System.Drawing.Image image = pictureBox1.Image;
            back2.setImagem(image);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            saveFileDialog.Title = "Salvar Arquivo";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "arquivo";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine(nome + ";" + classe + ";" + nivel + ";" + raca);
                }
                if (back2.getImagem() != null)
                {
                    string caminhoImagem = Path.ChangeExtension(caminhoArquivo, ".png");
                    back2.getImagem().Save(caminhoImagem, System.Drawing.Imaging.ImageFormat.Png);
                }
                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Exibir exibir2 = new Exibir(nome, classe, nivel, raca, image);
            exibir2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecionar Imagem do Personagem";
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o tamanho da imagem ao PictureBox
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = label1.Text;
            string classe = label2.Text;
            int nivel = int.Parse(label3.Text);
            string raca = label4.Text;
            System.Drawing.Image image = pictureBox1.Image;
            if (image != null)
            {
                pictureBox1.Image = new Bitmap(image); // Cria cópia em memória
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Para evitar distorção
            }
            Exibir voltar = new Exibir(nome, classe, nivel, raca, image);
            voltar.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int z = textBox1.Text.Length;
            int a = textBox2.Text.Length;
            int x = textBox3.Text.Length;
            int y = textBox4.Text.Length;
            if (a == 0 && z == 0 && x == 0 && y == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int z = textBox1.Text.Length;
            int a = textBox2.Text.Length;
            int x = textBox3.Text.Length;
            int y = textBox4.Text.Length;
            if (a == 0 && z == 0 && x == 0 && y == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int z = textBox1.Text.Length;
            int a = textBox2.Text.Length;
            int x = textBox3.Text.Length;
            int y = textBox4.Text.Length;
            if (a == 0 && z == 0 && x == 0 && y == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int z = textBox1.Text.Length;
            int a = textBox2.Text.Length;
            int x = textBox3.Text.Length;
            int y = textBox4.Text.Length;
            if (a == 0 && z == 0 && x == 0 && y == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }
    }
}
