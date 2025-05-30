using System.Security.Cryptography.X509Certificates;
using static JogoTerraria.personagem;

namespace JogoTerraria
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            personagem back = new personagem();

            back.setNome(textBox1.Text);
            string nome = back.getNome();

            back.setClasse(textBox2.Text);
            string classe = back.getClasse();

            int converter = int.Parse(textBox3.Text);
            if (converter < 1 && converter > 100)
            {
                MessageBox.Show("Nível inválido. Deve estar entre 1 e 100.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            back.setNivel(converter);
            int nivel = back.getNivel();

            back.setRaca(textBox4.Text);
            string raca = back.getRaca();

            Image imagem = pictureBox1.Image;
            back.setImagem(imagem);

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
                if (back.getImagem() != null)
                {
                    string caminhoImagem = Path.ChangeExtension(caminhoArquivo, ".png");
                    back.getImagem().Save(caminhoImagem, System.Drawing.Imaging.ImageFormat.Png);
                }
                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Exibir exibir = new Exibir(nome, classe, nivel, raca, imagem);
            exibir.Show();
            this.Hide();

        }





        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecionar Imagem do Personagem";
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o tamanho da imagem ao PictureBox
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblRaca_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
