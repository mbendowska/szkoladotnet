/*
Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L8E5
{
    public class Program
    {
        public static void Main(string[] args)
        {         
            for (long i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}^3={i*i*i}");
            }
        }
    }
}