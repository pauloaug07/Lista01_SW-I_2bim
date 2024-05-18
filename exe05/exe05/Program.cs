namespace exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            // Adicionando algumas tarefas para teste
            gerenciador.AdicionarTarefa(new Tarefa("Estudar para a prova", new DateTime(2024, 5, 17)));
            gerenciador.AdicionarTarefa(new Tarefa("Fazer compras", new DateTime(2024, 5, 21)));
            gerenciador.AdicionarTarefa(new Tarefa("Enviar relatório", new DateTime(2024, 5, 22)));

            // Listando as tarefas
            gerenciador.ListarTarefas();

            // Verificando as tarefas para hoje
            gerenciador.VerificarTarefasParaHoje();
        }
    }
}
