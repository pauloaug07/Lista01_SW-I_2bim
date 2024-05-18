using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    class Imovel
    {
        private string Endereco { get; set; }
        private double Preco { get; set; }
        private string Tipo { get; set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public void AlterarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }
    }
}
