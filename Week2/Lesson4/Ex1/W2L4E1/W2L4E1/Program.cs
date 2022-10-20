using System;
using System.Runtime.CompilerServices;

namespace W2L4Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string imie = "Joanna";
            string nazwisko = "Styczeń";
            byte wiek = 23;
            char plec = 'k';
            string pesel = "99062702455";
            long nrprac = 2509324094;
            Console.WriteLine($"Imię:\t\t{imie}");
            Console.WriteLine($"Nazwisko:\t{nazwisko}");
            Console.WriteLine($"Wiek:\t\t{wiek}");
            if ((plec == 'k') || (plec == 'K'))
            {
                Console.WriteLine("Płeć:           KOBIETA");
            }
            else
            {
                Console.WriteLine("Płeć:           MĘŻCZYZNA");
            }
            Console.WriteLine($"Pesel:\t\t{pesel}");
            Console.WriteLine($"Nr pracownika:\t{nrprac}");
        }
    }

}