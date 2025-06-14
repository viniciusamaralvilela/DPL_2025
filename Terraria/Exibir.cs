using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace JogoTerraria
{
    public partial class Exibir : Form
    {
        public Exibir()
        {
            InitializeComponent();
            // Labels podem ficar vazias ou mostrar um texto padrão
        }
        public Exibir(string nome, string classe, int nivel, string raca, Image image)
        {
            InitializeComponent();
            label5.Text = nome;
            label6.Text = classe;
            label7.Text = raca;
            label8.Text = nivel.ToString();
            if (image != null)
            {
                pictureBox1.Image = new Bitmap(image); // Cria cópia em memória
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Para evitar distorção
            }

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nome = label5.Text;
            string classe = label6.Text;
            string raca = label7.Text;
            int nivel = int.Parse(label8.Text);
            Image image = pictureBox1.Image;


            editar editarForm = new editar(nome, classe, nivel, raca, image);
            editarForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string nome = label5.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string classe = label6.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string raca = label7.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string nivel = label8.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
