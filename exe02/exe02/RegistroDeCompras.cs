using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    class RegistroDeCompras
    {
        // Atributos privados
        private List<Compra> compras;

        // Construtor
        public RegistroDeCompras()
        {
            compras = new List<Compra>();
        }

        // Método para adicionar uma compra
        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            Compra compra = new Compra(data, produto, valor);
            compras.Add(compra);
            Console.WriteLine("Compra adicionada com sucesso!");
        }

        // Método para listar todas as compras
        public void ListarCompras()
        {
            if (compras.Count == 0)
            {
                Console.WriteLine("Nenhuma compra registrada.");
                return;
            }

            foreach (Compra compra in compras)
            {
                Console.WriteLine($"Data: {compra.Data.ToShortDateString()}, Produto: {compra.Produto}, Valor: R${compra.Valor:F2}");
            }
        }
    }
}
