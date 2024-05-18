namespace exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Tentando criar um fabricante com nome vazio
                Fabricante fabricante1 = new Fabricante("", "Rua ABC, 123", "CidadeA");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro ao criar fabricante:");
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Criando um fabricante válido
                Fabricante fabricante2 = new Fabricante("Empresa XYZ", "Rua XYZ, 456", "CidadeB");

                // Tentando criar um produto com nome vazio
                Produto produto1 = new Produto("", fabricante2, 50.0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro ao criar produto:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}