using System;
using System.Runtime.CompilerServices;

namespace W2L4E3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość prostokąta");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość prostokąta");
            double b = double.Parse(Console.ReadLine());

            double Result = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));

            Console.WriteLine($"Długość przekątnej prostokąta o bokach {a} i {b} wynosi {Result.ToString()}");
        }
    }
}