/*
Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:
Wynik z Matury z matematyki powyżej 70
Wynik z fizyki powyżej 55
Wynik z chemii powyżej 45
Łączny wynik z 3 przedmiotów powyżej 180
Albo
Wynik z matematyki i jednego przedmiotu powyżej 150

Dane testowe:
Matematyka 80
Fizyka 71
Chemia 0
Rezultat w terminalu :
Kandydat dopuszczony do rekrutacji
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L7E8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę punktów z matematyki");
            double mpoints = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę punktów z fizyki");
            double ppoints = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę punktów z chemii");
            double cpoints = double.Parse(Console.ReadLine());

            double total = mpoints + ppoints + cpoints;

            Console.WriteLine($"Razem punktów: {total}");

            if (((mpoints>70) && (ppoints > 55) && (cpoints > 45)) && ((total >180) || ((mpoints+ppoints>150) || (mpoints+cpoints>150))))
            {
                Console.WriteLine("Możesz ubiegać się o miejsce na studiach");
            }
            else 
            {
                Console.WriteLine($"Nie możesz ubiegać się o miejsce na studiach");
            }
        }
    }
}