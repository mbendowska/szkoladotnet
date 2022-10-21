/*
Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę 
Dane testowe : 4
Rezultat w terminalu : Czwartek
*/
using System;
using System.Runtime.CompilerServices;

namespace W2L7E12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia");
            byte idday = byte.Parse(Console.ReadLine());
            switch (idday)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mamy tylko 7 dni w tygodniu. Możesz wpisać cyfry od 1 do 7!!! Popraw dane!!!");
                    Console.ResetColor();
                    break;
            }
        }
    }
}