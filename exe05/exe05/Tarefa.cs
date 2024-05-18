using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe05
{
    class Tarefa
    {
        private string descricao;
        private DateTime dataVencimento;

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            this.descricao = descricao;
            this.dataVencimento = dataVencimento;
        }

        public string Descricao 
        { 
            get { return descricao; }
        }
        public DateTime DataVencimento 
        { 
            get { return dataVencimento; } 
        }
    }
}
