namespace exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            CorretoraDeImoveis corretora = new CorretoraDeImoveis();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1. Adicionar imóvel");
                Console.WriteLine("2. Alterar preço de um imóvel");
                Console.WriteLine("3. Listar imóveis");
                Console.WriteLine("4. Calcular valor médio dos imóveis");
                Console.WriteLine("5. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o endereço do imóvel:");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Digite o preço do imóvel:");
                        double preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o tipo do imóvel:");
                        string tipo = Console.ReadLine();
                        corretora.AdicionarImovel(new Imovel(endereco, preco, tipo));
                        break;
                    case 2:
                        Console.WriteLine("Digite o endereço do imóvel:");
                        string enderecoAlteracao = Console.ReadLine();
                        Console.WriteLine("Digite o novo preço do imóvel:");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPreco(enderecoAlteracao, novoPreco);
                        break;
                    case 3:
                        corretora.ListarImoveis();
                        break;
                    case 4:
                        double valorMedio = corretora.CalcularValorMedio();
                        Console.WriteLine($"O valor médio dos imóveis é: R${valorMedio:F2}");
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite novamente.");
                        break;
                }
            }
        }
    }
}
