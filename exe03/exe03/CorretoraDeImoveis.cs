using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03 { 
    class CorretoraDeImoveis 
    {
        private List<Imovel> imoveis;

        public CorretoraDeImoveis()
        {
            imoveis = new List<Imovel>();
        }

        public void AdicionarImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
        }

        public void AlterarPreco(string endereco, double novoPreco)
        {
            Imovel imovel = imoveis.Find(i => i.GetEndereco() == endereco);
            if (imovel != null)
            {
                imovel.AlterarPreco(novoPreco);
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        public void ListarImoveis()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel disponível.");
            }
            else
            {
                Console.WriteLine("Lista de imóveis:");
                foreach (var imovel in imoveis)
                {
                    Console.WriteLine($"Endereço: {imovel.GetEndereco()}, Preço: R${imovel.GetPreco():F2}, Tipo: {imovel.GetTipo()}");
                }
            }
        }

        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                return 0;
            }
            else
            {
                double soma = imoveis.Sum(i => i.GetPreco());
                return soma / imoveis.Count;
            }
        }
    } 
}
