using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quntos quilometros a em 1 milha?");
            double M=1;
            double K=1.609;
            double resultado=K * M;
            Console.Write($"{resultado}");
            Console.WriteLine("km");
        }
    }
}
