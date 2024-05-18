namespace exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            // Adicionando alguns contatos para teste
            agenda.AdicionarContato(new Contato("João", "123456789", "joao@email.com"));
            agenda.AdicionarContato(new Contato("Maria", "987654321", "maria@email.com"));

            // Testando a busca de um contato
            Console.WriteLine("Buscando o contato de João:");
            Contato contatoJoao = agenda.BuscarContato("João");
            if (contatoJoao != null)
            {
                Console.WriteLine($"Nome: {contatoJoao.Nome}, Telefone: {contatoJoao.Telefone}, Email: {contatoJoao.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            // Testando a remoção de um contato
            Console.WriteLine("\nRemovendo o contato de Maria:");
            agenda.RemoverContato("Maria");

            // Tentando buscar o contato removido
            Console.WriteLine("\nBuscando o contato de Maria após remoção:");
            Contato contatoMaria = agenda.BuscarContato("Maria");
            if (contatoMaria != null)
            {
                Console.WriteLine($"Nome: {contatoMaria.Nome}, Telefone: {contatoMaria.Telefone}, Email: {contatoMaria.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }
}
