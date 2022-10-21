/*
Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
Dane testowe:
25
63
79
Rezultat w terminalu :
79 jest największa z podanych
*/
using System;
using System.Runtime.CompilerServices;

namespace W2L4E7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbę");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę");
            double c = double.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine($"Liczba {a} jest największą liczbą z podanych");
            }
            else if (b > c)
                 {
                     Console.WriteLine($"Liczba {a} jest największą liczbą z podanych");
                 }
                 else if ((a==b) && (b==c))
                      {
                            Console.WriteLine($"Liczby {a} , {b} , {c} są sobie równe");
                      }
                      else Console.WriteLine($"Liczba {c} jest największą liczbą z podanych");
        }
    }
}