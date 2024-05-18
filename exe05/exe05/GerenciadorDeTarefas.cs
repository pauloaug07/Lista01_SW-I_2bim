using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe05
{
    class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas;

        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefa = tarefas.Find(t => t.Descricao == descricao);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine($"Tarefa '{descricao}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa '{descricao}' não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa disponível.");
            }
            else
            {
                Console.WriteLine("Lista de tarefas:");
                foreach (var tarefa in tarefas)
                {
                    Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                }
            }
        }

        public void VerificarTarefasParaHoje()
        {
            DateTime hoje = DateTime.Today;
            List<Tarefa> tarefasParaHoje = tarefas.FindAll(t => t.DataVencimento.Date == hoje);
            if (tarefasParaHoje.Count == 0)
            {
                Console.WriteLine("Não há tarefas para hoje.");
            }
            else
            {
                Console.WriteLine("Tarefas para hoje:");
                foreach (var tarefa in tarefasParaHoje)
                {
                    Console.WriteLine($"Descrição: {tarefa.Descricao}");
                }
            }
        }
    }
}
