using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digíte um valor de milha,como exemplo 1, 2, 3...");
            Console.Write("Escreva o valor de uma milha:");
            double M=Convert.ToDouble(Console.ReadLine());
            double K=1.609;
            double resultado=K * M;
            Console.Clear();
            Console.Write($"Resultado da sua milha para quilômetros= {resultado}km");
            
        }
    }
}
