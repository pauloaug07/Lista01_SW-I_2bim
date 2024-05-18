using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe04
{
    class Contato
    {
        private string nome;
        private string telefone;
        private string email;

        public Contato(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public string Nome 
        {
            get { return nome; }
        }
        public string Telefone 
        { 
            get { return telefone; } 
        }
        public string Email 
        { 
            get { return email; } 
        }
    }
}
