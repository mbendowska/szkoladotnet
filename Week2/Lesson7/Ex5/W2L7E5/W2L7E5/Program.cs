/*
Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
Dane testowe : 21
Rezultat w terminalu :
Możesz zostać posłem
 */

using System;
using System.Runtime.CompilerServices;

namespace W2L7E5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek");
            int age = int.Parse(Console.ReadLine());

            if ((age < 21)&&(age>=18))
            {
                Console.WriteLine("Możesz brać udział w wborach");
            }
            else
            {
                if (age >= 21)
                {
                    Console.WriteLine("Możesz zostać posłem");
                    Console.WriteLine("Możesz zostać premierem");
                }
                if (age >= 30)
                {
                    Console.WriteLine("Możesz zostać senatorem");
                }
                if (age >= 35)
                {
                    Console.WriteLine("Możesz zostać prezydentem");
                }
                if (age < 18)
                {
                    Console.WriteLine("Jesteś jeszcze dzieckiem");
                }
            }
        }
    }
}