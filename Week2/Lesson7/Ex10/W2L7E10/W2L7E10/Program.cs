/*
Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt 
Dane testowe : 40 55 65 
Rezultat w terminalu : Można zbudować trójkąt
*/
using System;
using System.Runtime.CompilerServices;

namespace W2L7E10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość pierwszego boku");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiego boku");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość trzeciego boku");
            double c = double.Parse(Console.ReadLine());

            double biggest = 0;
            double sumsides = 0;

            if ((a > b) && (a > c))
            {
                biggest = a;
                sumsides = b + c;
            }
            else if (b > c)
                 {
                    biggest = b;
                    sumsides = a + c;
                 }
                 else
                 {
                    biggest = c;
                    sumsides = a + b;
                 }
            if (sumsides > biggest)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Trójkąt można zbudować z boków o długościach {a}, {b}, {c}");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Z boków o długościach {a}, {b}, {c} nie można zbudować trójkąta!!!");
            }
            Console.ResetColor();
        }
    }
}