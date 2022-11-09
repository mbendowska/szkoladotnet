//Przywitanie użytkownika i krótki opis programu
//Dostanie możliwości wyboru akcji: 
//1. Dodanie do lisy wolontariusza /id, imię, nazwisko, wiek, miejscowosc, czy jest szkoleniowcem, czy jest ambasadorem/
//2. Usunięcie z listy wolontariusza
//3. Wyświetlenie wszystkich informacji o wolontariusz o podanym id
//4. Wyświetlenie listy wolontariuszy o zadanym filtrze wiekowym lub z określonej miejscowości

//1.1 Dostane do wyboru kategorię wolontariuszy (podstawowy, niepełnosprawny, szkoleniowiec, ambasador)
//1.2 Dostanę możliwość wprowadzenia wszyskich szczegółów wolontariusza
//2.1.Zostanę poproszona o wyświetlenie id wolontariusza do usuniecia
//2.2.Usunę wolontariusza z listy
//3.1 Zostanę poproszona o wprowadzenie id wolontariusza
//3.2 Wyświetlę wszystkie informacje o wolontariuszu
//4.1. Zostanę poproszona o wprowadzenie wieku wolontariusza lub mijescowości 
//4.2. Wyświetlę listę wolontariuszy o zadanym filtrze


using System;
using System.Runtime.CompilerServices;
using W2L20Project;

namespace W2L8Project
{


    public class Program
    {
        public static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            Console.WriteLine("Witam w aplikacji zarządzającej wolontariuszami");
            Console.WriteLine("Wybierz co chcesz zrobić");

            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}.{mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            ItemService itemService = new ItemService();
            switch (operation.KeyChar)
            {
                case '1':
                    var keyInfo = itemService.AddNewItemView(actionService);
                    var id = itemService.AddNewItem(keyInfo.KeyChar);
                    break;
                case '2':
                    var removeId = itemService.RemoveItemView();
                    itemService.RemoveItem(removeId);
                    break;
                case '3':
                    break;
                case '4':
                    break;
                default:
                    Console.WriteLine("Wybrałeś złą opcję!!!");
                    break;

            }


        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj wolontariusza", "Main");
            actionService.AddNewAction(2, "Usuń wolontariusza", "Main");
            actionService.AddNewAction(3, "Pokaż dane wolontariusza", "Main");
            actionService.AddNewAction(4, "Wyświetl listę wolontariuszy", "Main");

            actionService.AddNewAction(1, "Podstawowy", "AddNewItemMenu");
            actionService.AddNewAction(2, "Niepełnosprawny", "AddNewItemMenu");
            actionService.AddNewAction(3, "Szkoleniowiec", "AddNewItemMenu");
            actionService.AddNewAction(4, "Ambasador", "AddNewItemMenu");

            return actionService;
        }
    }
}

