using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe07
{
    public class Musica
    {
        // Atributos privados da música
        private string nome;
        private string autor;
        private string gravadora;

        // Construtor da música
        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }

        // Método público para obter o nome da música
        public string GetNome()
        {
            return nome;
        }

        // Método público para obter o autor da música
        public string GetAutor()
        {
            return autor;
        }

        // Método público para obter a gravadora da música
        public string GetGravadora()
        {
            return gravadora;
        }

        // Método para "tocar" a música
        public void Tocar()
        {
            Console.WriteLine($"Tocando: {nome}");
        }
    }
}
