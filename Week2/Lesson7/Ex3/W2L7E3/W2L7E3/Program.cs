/*
Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
Dane testowe : 14
Rezultat w terminalu :
14 jest liczbą dodatnią
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L7E3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double a = double.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"liczba {a} jest liczbą dodatnią");
            }
            else if (a < 0)
                 {
                    Console.WriteLine($"liczba {a} jest liczbą ujemną");
                 }
                else Console.WriteLine($"liczba {a} jest zerem");
        }
    }
}