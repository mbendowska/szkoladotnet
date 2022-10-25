/*Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
Testowe dane:
Abcdefg
Rezultat
Gfedcba*/
using System;
using System.Runtime.CompilerServices;

namespace W2L8E8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków, które mają zostać obrócone");
            string task = Console.ReadLine();
            for (int i = task.Length; i > 0 ; i--)
            {
                char temp =  task[i-1];
                Console.Write($"{temp}");                
            }
            Console.ReadKey();
        }
    }
}

