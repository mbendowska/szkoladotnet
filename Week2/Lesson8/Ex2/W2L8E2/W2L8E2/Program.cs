/*
Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000
*/

using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace W2L8E2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //0 nie jest liczbą parzystą w związku z tym, zaczynamy sprawdzanie od 1             
            int number = 1;
            Console.WriteLine("Liczby parzyste z przedziału od 0-1000");
            do
            {
                if ((number % 2) == 0)
                {
                    Console.Write($"{number} ,");
                }
                number++;
            }
            while (number <= 1000);
        }
    }
}
