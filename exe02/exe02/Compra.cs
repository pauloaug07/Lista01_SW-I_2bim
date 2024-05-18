using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    class Compra
    {
        // Atributos privados
        private DateTime data;
        private string produto;
        private double valor;

        // Propriedades públicas somente leitura
        public DateTime Data
        {
            get { return data; }
        }
        
        public string Produto
        {
            get { return produto; }
        }
        
        public double Valor
        {
            get { return valor; }
        }

        // Construtor
        public Compra(DateTime data, string produto, double valor)
        {
            this.data = data;
            this.produto = produto;
            this.valor = valor;
        }
    }
}

