namespace exe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma instância da classe RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras();

            // Adicionando algumas compras
            registro.AdicionarCompra(new DateTime(2023, 5, 15), "Notebook", 3500.00);
            registro.AdicionarCompra(new DateTime(2023, 6, 20), "Smartphone", 1500.00);
            registro.AdicionarCompra(new DateTime(2023, 7, 10), "Teclado Mecânico", 250.00);

            // Listando todas as compras
            Console.WriteLine("\nLista de compras registradas:");
            registro.ListarCompras();

            Console.ReadLine();
        }
    }
}
