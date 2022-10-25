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

//Zadanie 7
int p;
Console.WriteLine("Podaj przekątną:");
Int32.TryParse(Console.ReadLine(), out p);

for (int i = 0; i < p; i++)
{
    for (int j = 0; j < (p - i); j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = p - 2; i >= 1; i--)
{
    for (int j = 0; j < (p - i); j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
