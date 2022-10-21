/*
Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem 
Podaj pierwszą liczbę: … Podaj drugą liczbę: … Podaj numer operacji do wykonania:

1. Dodawanie
2. Odejmowanie
3. Mnożenie
4. Dzielenie
…
Twój wynik to:
*/

using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace W2L7E13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbę");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz jedną z możliwych opcji");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Dodawanie");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("2. Odejmowanie");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("3. Mnożenie");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("4. Dzielenie");
            Console.ResetColor();

            byte option= byte.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    score = a + b;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Wynik dodawania: {a}+{b}={a+b}");
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    score = a - b;
                    Console.WriteLine($"Wynik odejmowania: {a}-{b}={a-b}");
                    score = b - a;
                    Console.WriteLine($"Wynik odejmowania: {b}-{a}={b-a}");
                    break;
                case 3:
                    score = a * b;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Wynik mnożenia: {a}*{b}={a*b}");
                    break;
                case 4:
                    if (b!=0)
                    {
                        score = a / b;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Wynik dzielenia: {a}/{b}={a/b}");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nigdy cholero nie dziel przez 0!!!");
                    } 
                    break;               
                default:                                      
                    break;
            }
            Console.ResetColor();
        }
    }
}