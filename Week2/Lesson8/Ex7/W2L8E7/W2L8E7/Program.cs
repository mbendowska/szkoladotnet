/*Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru: 
  Dla liczby 9 wygląda to tak:
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
*/

using System;
using System.Runtime.CompilerServices;

namespace W2L8E7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmair krótszej przekątnej diamentu. Jeżeli podasz liczbę parzystą to zwiększę to o 1! :)");
            int diagonal = Int32.Parse(Console.ReadLine());
            int d1;
            int d2 = 1;
            bool top = true;

            if (diagonal < 1)
            {
                Console.WriteLine("Przekątna musi być większa od 0");
            }
            else
            {
                if (diagonal % 2 == 0)
                {
                    diagonal++;
                    Console.WriteLine("Zwiększono o 1 podany wymiar przekątnej");
                }
                d1 = diagonal / 2;
                for (int i = 0; i < diagonal; i++)
                {
                    if (i == diagonal / 2)
                    {
                        top = false;
                    }
                    for (int z = 0; z < d1; z++)
                    {
                        Console.Write(" ");
                    }
                    for (int x = 0; x < d2; x++)
                    {
                        Console.Write("*");
                    }
                    if (top)
                    {
                        if (i != diagonal / 2)
                        {
                            d2 = d2 + 2;
                        }
                        if (d1 > 0)
                        {
                            d1--;
                        }
                    }
                    else
                    {
                        d1++;
                        if (d2 > 1)
                        {
                            d2 = d2-2;
                        }
                    }
                    Console.WriteLine();
                }          
            }
        }
    }
}
