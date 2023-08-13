using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome para iniciarmos! \n");
            string nome = Console.ReadLine();
            Console.Write("Insira sua idade: \n");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira sua altura: \n");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira seu peso: \n");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"nome: {nome}\n idade: {idade} \n altura: {altura} \n peso: {peso}.");
        }
    }
}