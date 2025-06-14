using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoTerraria
{
    class personagem
    {
        private string nome;
        private string raca;
        private int nivel;
        private string classe;
        private Image imagem;
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getRaca()
        {
            return raca;
        }
        public void setRaca(string raca)
        {
            this.raca = raca;
        }
        public int getNivel()
        {
            return nivel;
        }
        public void setNivel(int nivel)
        {
            if (nivel < 1 && nivel > 100)
            {
                MessageBox.Show("Numero invalido");
            }
            else
            {
                this.nivel = nivel;
            }
        }
        public string getClasse()
        {
            return classe;
        }
        public void setClasse(string classe)
        {
            this.classe = classe;
        }
        public Image getImagem()
        {
            return imagem;
        }

        public void setImagem(Image imagem)
        {
            this.imagem = imagem;
        }
        public personagem(string nome, string classe, int nivel, string raca)
        {
            this.nome = nome;
            this.classe = classe;
            this.nivel = nivel;
            this.raca = raca;
        }
        public personagem(){} // Construtor padrão necessário para a classe

}
}
