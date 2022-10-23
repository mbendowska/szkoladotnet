/*
Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L8E2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Liczby pierwsze z przedziału od 0-100");
            //0 i 1 nie są liczbami pierwszymi więc nie ma konieczności ich sprawdzania czy są podzielne przez 1 i samą siebie. Stąd pętla for zaczyna się od 2.
            for (byte number = 2; number <= 100; number++)
            {
                byte counter= 0;
                for (byte divider = 1; divider  <= 100; divider++)
                {
                    if ((number % divider) == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.Write($"{number} ,");
                }
            }
        }
    }
}
