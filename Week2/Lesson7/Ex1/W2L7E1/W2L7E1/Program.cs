/*
Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
Dane testowe:
a: 5
b: 5
Rezultat w terminalu :
5 i 5 są równe
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L7E1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            if (a == b)
            { 
                Console.WriteLine ($"Liczby {a} i {b} są równe");
            }             
            else
            {
                Console.WriteLine($"Liczby {a} i {b} nie są równe");
            }
        }
    }
}