using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe06
{
    class ListaDeProdutos
    {
        private List<Produto> produtos;

        public ListaDeProdutos()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                produto.MostrarInformacoes();
            }
        }

        public Produto BuscarProduto(string nome)
        {
            foreach (var produto in produtos)
            {
                if (produto.GetNome() == nome)
                {
                    return produto;
                }
            }
            return null;
        }
    }
}
