namespace exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um animal
            Animal animal = new Animal("Rex", "Cachorro", 3, "Au Au!");

            // Emitindo o som do animal
            animal.EmitirSom(); // Saída: O Cachorro Rex emite o som: Au Au!

        }
    }
}
