using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe08
{
    class Fabricante
    {
        // Propriedades
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do fabricante não pode estar vazio.");
                }
                _nome = value;
            }
        }

        private string Endereco { get; set; }
        private string Cidade { get; set; }

        // Construtor
        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
        }
    }
}
