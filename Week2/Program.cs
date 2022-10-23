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
            for (byte number = 0; number <= 100; number++)
            {
                byte licznik = 0;
                for (byte dziel = 1; dziel<10; dziel++)
                {
                  if ((number % dziel) == 0)
                  {
                     licznik++;
                  }
                }
                if (licznik == 2)
                {
                    Console.WriteLine($"Liczba {number}");
                }
            }
        }
    }
}
