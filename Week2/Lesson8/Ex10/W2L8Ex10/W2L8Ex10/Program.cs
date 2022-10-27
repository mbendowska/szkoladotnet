// Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb

using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace W2L8E9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int second = int.Parse(Console.ReadLine());

            int result = first * second;

            while (first!=second)
            {
                if (first > second)
                {
                    first = first - second;
                }
                else
                {
                    second = second - first;
                }
            }
            result = result / second;
            Console.WriteLine($"{result}");
            //Console.ReadKey();
        }
    }
}