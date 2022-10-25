// Napisz program, który zamieni liczbę dziesiętną na liczbę binarną
using System;
using System.Runtime.CompilerServices;

namespace W2L8E9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj całkowitą liczbę dziesiętną");
            int number = int.Parse(Console.ReadLine());
            string result = "";
            while (number>0)
            {
                int temp=number % 2;
                result = temp + result;
                number= number/2;               
            }
            Console.WriteLine($"{result}");
            //Console.ReadKey();
        }
    }
}

