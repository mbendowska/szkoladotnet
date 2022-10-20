/*
Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
Dane testowe : 2016
Rezultat w terminalu :
2016 jest rokiem przestępnym
 */

using System;
using System.Runtime.CompilerServices;

namespace W2L7E4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok");
            int year = int.Parse(Console.ReadLine());
            if (((year%4==0) && (year%100!=0)) || (year%400==0))
            {
                Console.WriteLine($"Rok {year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"Rok {year} nie jest rokiem przestępnym");
            }            
        }
    }
}
