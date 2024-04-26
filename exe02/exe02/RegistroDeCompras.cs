using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    public class RegistroDeCompras
    {
        private string produto;
        private double valor;
        private DateTime data;

        public RegistroDeCompras(string produto, double valor, DateTime data)
        {
            this.produto = produto;
            this.valor = valor;
            this.data = data;
        }
    }
}
