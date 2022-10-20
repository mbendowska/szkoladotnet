/*
Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
Dane testowe : 15
Rezultat w terminalu :
15 jest liczbą nieparzystą
 */
using System;
using System.Runtime.CompilerServices;

namespace W2L7E2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int a = int.Parse(Console.ReadLine());

            if (a%2 == 0)
            {
                Console.WriteLine($"Liczba {a} jest liczbą parzystą ");
            }
            else
            {
                Console.WriteLine($"Liczba {a} jest liczbą nieparzystą ");
            }
            
        }
    }
}