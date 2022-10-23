/*
Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L8E3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            long number = long.Parse(Console.ReadLine());
            long a = 0;
            long b = 0;
            long c = 0;

            for (long i = 1; i < number; i++)
            {
                if (i <= 2)
                {
                    Console.Write("1, ");
                    a = 1;
                    b = 1;
                }
                else
                {
                    Console.Write($"{a + b}, ");
                    c = a;
                    a = a + b;
                    b = c;
                }
            }
        }
    }
}