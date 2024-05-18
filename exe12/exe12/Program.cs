namespace exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Armazenar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite a altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case "2":
                        Console.Write("Digite o nome da pessoa a ser removida: ");
                        nome = Console.ReadLine();
                        agenda.RemovePessoa(nome);
                        break;
                    case "3":
                        Console.Write("Digite o nome da pessoa a ser buscada: ");
                        nome = Console.ReadLine();
                        Pessoa pessoa = agenda.BuscaPessoa(nome);
                        if (pessoa != null)
                        {
                            pessoa.MostrarInformacoes();
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada.");
                        }
                        break;
                    case "4":
                        agenda.ImprimeAgenda();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
