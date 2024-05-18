using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe12
{
    class Pessoa
    {
        // Atributos privados
        private string nome;
        private int idade;
        private float altura;

        // Propriedades com encapsulamento e validação
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome não pode ser vazio ou nulo.");
                }
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }
            }
        }

        public float Altura
        {
            get { return altura; }
            set
            {
                if (value >= 0)
                {
                    altura = value;
                }
                else
                {
                    throw new ArgumentException("A altura não pode ser negativa.");
                }
            }
        }

        // Construtor
        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        // Método para exibir as informações da pessoa
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Altura: {Altura} m");
        }
    }
}
