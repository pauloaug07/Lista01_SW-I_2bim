using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe08
{
    class Produto
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
                    throw new ArgumentException("O nome do produto não pode estar vazio.");
                }
                _nome = value;
            }
        }

        private Fabricante Fabricante { get; set; }
        private double _preco;

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value >= 0)
                {
                    _preco = value;
                }
                else
                {
                    throw new ArgumentException("O preço deve ser um valor positivo.");
                }
            }
        }

        // Construtor
        public Produto(string nome, Fabricante fabricante, double preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preco = preco;
        }
    }
}
