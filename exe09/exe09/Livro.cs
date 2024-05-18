using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe09
{
    class Livro
    {
        // Propriedades
        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O título do livro não pode estar vazio.");
                }
                _titulo = value;
            }
        }

        private string _autor;
        public string Autor
        {
            get { return _autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O autor do livro não pode estar vazio.");
                }
                _autor = value;
            }
        }

        // Construtor
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
