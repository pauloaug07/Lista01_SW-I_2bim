namespace exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma instância da classe Carro
            Carro meuCarro = new Carro("Toyota", new DateOnly(2020, 1, 1), 0);

            // Exibir as informações iniciais do carro
            Console.WriteLine("Carro criado:");
            meuCarro.MostrarInformacoes();

            // Testando o método AumentarVelocidade
            Console.WriteLine("\nTestando AumentarVelocidade:");
            meuCarro.AumentarVelocidade(); // Deve aumentar para 10 km/h
            meuCarro.AumentarVelocidade(); // Deve aumentar para 20 km/h

            // Exibir as informações do carro após acelerar
            Console.WriteLine("\nInformações do carro após acelerar:");
            meuCarro.MostrarInformacoes();

            // Testando o método DiminuirVelocidade
            Console.WriteLine("\nTestando DiminuirVelocidade:");
            meuCarro.DiminuirVelocidade(); // Deve diminuir para 10 km/h
            meuCarro.DiminuirVelocidade(); // Deve diminuir para 0 km/h
            meuCarro.DiminuirVelocidade(); // Deve informar que o carro já está parado

            // Exibir as informações do carro após desacelerar
            Console.WriteLine("\nInformações do carro após desacelerar:");
            meuCarro.MostrarInformacoes();

            // Testando a validação de velocidade inicial
            try
            {
                Carro carroInvalido = new Carro("Honda", new DateOnly(2019, 1, 1), -10);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\nErro ao criar o carro: " + ex.Message);
            }

            Console.ReadLine();
        } 
    } 
}
