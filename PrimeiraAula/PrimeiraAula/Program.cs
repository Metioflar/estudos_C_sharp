using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do RAIO do círculo para que possamos calcular a sua área. \n");
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do círculo é {area.ToString("N2")}");
            Console.ReadKey();
        }
    }
}



