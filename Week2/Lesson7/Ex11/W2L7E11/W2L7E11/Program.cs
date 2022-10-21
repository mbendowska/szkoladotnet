/*
Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
Ocena Opis
6 Celujący
5 Bardzo dobry
4 Dobry
3 Dostateczny
2 Dopuszczający
1 Niedostateczny 

Dane testowe : 3 
Rezultat w terminalu : Dostateczny
 */

using System;
using System.Runtime.CompilerServices;

namespace W2L7E11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj uzyskaną ocenę");
            byte rate = byte.Parse(Console.ReadLine());        
            switch(rate)
                { 
                    case 1:
                        Console.WriteLine("Ocena niedostateczna");
                        break;
                    case 2:
                        Console.WriteLine("Ocena dopuszczająca");
                        break;
                    case 3:
                        Console.WriteLine("Ocena dostateczna");
                        break;
                    case 4:
                        Console.WriteLine("Ocena dobra");
                        break;
                    case 5:
                        Console.WriteLine("Ocena bardzo dobra");
                        break;
                    case 6:
                        Console.WriteLine("Ocena celująca");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ocenę możesz uzyskać w skali od 1 do 6. Popraw dane!!!");
                        Console.ResetColor();
                    break;
            }
        }
                       
    }
}

