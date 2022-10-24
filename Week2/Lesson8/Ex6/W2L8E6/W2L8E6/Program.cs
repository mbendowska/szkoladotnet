/*
Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
1 + ½ + 1/3 + ¼ itd.
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L8E6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double result = 0.0;
            double temp = 0.0;
            for (int i = 1; i < 20; i++)
            {
                Console.Write($"1/{i}+");
                temp= 1.0 / i;
                result = result+temp;
            }           
            temp = 1.0 / 20;
            result = result + temp;
            Console.WriteLine($"1/{20}={result}");
        }
    }
}