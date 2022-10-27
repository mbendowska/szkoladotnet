/*
Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
1 
2 3 
4 5 6 
7 8 9 10
*/
using System;
using System.Runtime.CompilerServices;

namespace W2L8E4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę calkowitą");
            int number = Int32.Parse(Console.ReadLine());
            int a = 0;
            if (number <= 0)
            {
                Console.WriteLine("Podałeś złą liczbę. Liczba musi być większa od 0!!!");
            }
            else
            {
                for (int i = 1; a < number; i++)
                {
                    for (int z = 1; z <= i; z++)
                    {
                        a++;
                        Console.Write($"{a}  ");
                        if (a == number)
                        {
                            break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
