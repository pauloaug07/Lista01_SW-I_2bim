using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe11
{
    class Carro
    {
        private string? marca;
        private DateOnly ano;
        private int velocidade;

        public string? Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    marca = value;
                }
                else
                {
                    throw new ArgumentException("A marca não pode ser vazia ou nula.");
                }
            }
        }

        public DateOnly Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Velocidade
        {
            get { return velocidade; }
            set
            {
                if (value >= 0)
                {
                    velocidade = value;
                }
                else if (value < 0)
                {
                    throw new ArgumentException("A velocidade inicial não pode ser menor que 0km/h");
                }
            }
        }

        public Carro(string? marca, DateOnly ano, int velocidadeInicial)
        {
            Marca = marca;
            Ano = ano;
            Velocidade = velocidadeInicial;
        }

        public void AumentarVelocidade()
        {
            if (velocidade >= 150)
            {
                Console.WriteLine("Você já atingiu a velocidade máxima e não pode acelerar mais");
            }
            else if (velocidade >= 0 && velocidade < 150)
            {
                velocidade += 10;
                Console.WriteLine("A velocidade aumentou em 10km/h e agora tem o valor de: " + velocidade + "km/h");
            }
        }

        public void DiminuirVelocidade()
        {
            if (velocidade == 0)
            {
                Console.WriteLine("O carro já está parado. Não é possível diminuir a velocidade");
            }
            else if (velocidade >= 10)
            {
                velocidade -= 10;
                Console.WriteLine("A velocidade diminuiu em 10km/h e agora tem o valor de: " + velocidade + "km/h");
            }
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Ano: {Ano.Year}");
            Console.WriteLine($"Velocidade: {velocidade} km/h");
        }
    }
}
