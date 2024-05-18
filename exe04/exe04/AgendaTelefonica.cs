using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe04
{
    class AgendaTelefonica
    {
        private List<Contato> contatos;

        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        public void RemoverContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine($"Contato '{nome}' removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Contato '{nome}' não encontrado.");
            }
        }

        public Contato BuscarContato(string nome)
        {
            return contatos.Find(c => c.Nome == nome);
        }
    }
}
