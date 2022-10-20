using System;
using System.Runtime.CompilerServices;

namespace W2L4E3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Podaj imię");
            string imie = Console.ReadLine();
            
            Console.WriteLine("Podaj nazwisko");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj wiek");
            int wiek = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj adres e-mail");
            string email = Console.ReadLine();

            Console.WriteLine("Podaj wzrost w cm");
            int wzrost = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wagę");
            double waga = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj płeć [k/m]");
            char plec = char.Parse(Console.ReadLine());

            // Console.WriteLine("Czy jesteś dzieckiem? [0-Nie 1-Tak]");
            // bool dziecko = bool.Parse(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("WPROWADZONE PRZEZ CIEBIE DANE");
            Console.WriteLine("=============================");
                                    
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Imię i nazwisko: {imie}  {nazwisko}");
            Console.WriteLine($"Masz {wiek}  lat");
            Console.WriteLine($"Twój adres e-mail to {email}");
            Console.WriteLine($"Twój wzrost to: {wzrost} a Twoja waga wynosi {waga} kg");
            if ((plec == 'k') || (plec == 'K'))
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Płeć: KOBIETA");
                
            }
            else if ((plec == 'm') || (plec == 'M'))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Płeć: MĘŻCZYZNA");
            }
                  else 
                  {
                       Console.BackgroundColor = ConsoleColor.Red;
                       Console.WriteLine("Wprowadziłeś nieprawidłowe dane dotyczące płci!!!");
                  }
            Console.ResetColor();
        }
    }
}