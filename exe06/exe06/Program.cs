namespace exe06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDeProdutos listaDeProdutos = new ListaDeProdutos();

            Produto produto1 = new Produto("Camiseta", 29.99, 50);
            Produto produto2 = new Produto("Calça Jeans", 59.99, 30);
            Produto produto3 = new Produto("Tênis", 99.99, 20);

            listaDeProdutos.AdicionarProduto(produto1);
            listaDeProdutos.AdicionarProduto(produto2);
            listaDeProdutos.AdicionarProduto(produto3);

            listaDeProdutos.ListarProdutos();

            string nomeParaBuscar = "Calça Jeans";
            Produto produtoConsultado = listaDeProdutos.BuscarProduto(nomeParaBuscar);

            if (produtoConsultado != null)
            {
                Console.WriteLine($"Produto encontrado com sucesso: {nomeParaBuscar}");
            }
            else
            {
                Console.WriteLine($"Produto com o nome {nomeParaBuscar} não encontrado.");
            }
        }
    }
}
