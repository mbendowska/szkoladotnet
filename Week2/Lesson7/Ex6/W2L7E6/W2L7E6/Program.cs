/* Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
Dane testowe : 140
Rezultat w terminalu :
Jesteś krasnoludem
*/
using System;
using System.Runtime.CompilerServices;

namespace W2L7E6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost w centymetrach");
            byte size = Byte.Parse(Console.ReadLine());

            if (size < 40)
            {
                Console.WriteLine("Jeszcze się nie urodziłeś");
            }
            else if (size < 100)
                {
                     Console.WriteLine("Jesteś bobaskiem");
                }
                else if ((size >= 100) && (size < 130))
                    {
                           Console.WriteLine("Jesteś krasnalem");
                    }
                      else if ((size >= 130) && (size < 160))
                           {
                                Console.WriteLine("Jesteś średniakiem");
                           }
                           else if ((size >= 160) && (size < 190))
                                {
                                     Console.WriteLine("Jestś duży");
                                }
                                else if ((size >= 190) && (size < 210))
                                     {
                                          Console.WriteLine("Jestś olbrzymi");
                                     }
                                     else Console.WriteLine("Jesteś wielkoludem i pamiętaj Małych ludzi Pan Bóg stworzył, a duże osły same porosły");
        }       
    }
}