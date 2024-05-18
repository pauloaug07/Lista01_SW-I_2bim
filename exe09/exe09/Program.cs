namespace exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Tentando criar um livro com título vazio
                Livro livro1 = new Livro("", "Autor Teste");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro ao criar livro:");
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Tentando criar um livro com autor vazio
                Livro livro2 = new Livro("Título Teste", "");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro ao criar livro:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
