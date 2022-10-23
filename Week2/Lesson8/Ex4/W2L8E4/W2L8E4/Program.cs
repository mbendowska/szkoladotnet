/*
Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
1 
2 3 
4 5 6 
7 8 9 10
*/
using System;
using System.Runtime.CompilerServices;

namespace W2L8E3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int number = Int32.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= number; i++)
            {
                
                
                
                
                for (int z=1; z<=i; z++)
                {
                    Console.Write(a + ", ");
                    a++;
                }
                Console.WriteLine("");
            }

 
        }
    }
}