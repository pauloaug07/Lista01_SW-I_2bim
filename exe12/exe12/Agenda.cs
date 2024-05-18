using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe12
{
    class Agenda
    {
        // Lista para armazenar as pessoas
        private List<Pessoa> pessoas;

        // Construtor
        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        // Método para armazenar uma pessoa na agenda
        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
            Console.WriteLine("Pessoa armazenada com sucesso!");
        }

        // Método para remover uma pessoa pelo nome
        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine("Pessoa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
        }

        // Método para buscar uma pessoa pelo nome
        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        // Método para imprimir todas as pessoas na agenda
        public void ImprimeAgenda()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("A agenda está vazia.");
            }
            else
            {
                foreach (Pessoa pessoa in pessoas)
                {
                    pessoa.MostrarInformacoes();
                    Console.WriteLine();
                }
            }
        }
    }
}
