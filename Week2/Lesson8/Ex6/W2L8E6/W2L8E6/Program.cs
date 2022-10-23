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
            for (int i = 1; i < 21; i++)
            {
                if (i==21)
                {
                    Console.WriteLine($"1/{i}");
                    temp = 1 / i;
                    result=result+temp;
                    Console.WriteLine(result);
                }
                Console.Write($"1/{i}+");
                temp = 1 / i;
                result=result+temp;
            }
        }
    }
}