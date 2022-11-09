using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L20Project
{
    public class ItemService
    {
        public List <Item> Items { get; set; }
        public ItemService()
        {
            Items = new List<Item>();
        }

        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine("Wybierz rodzaj wolontariusza");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }
        public int AddNewItem(char itemType)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);
            Item item = new Item(1, "");
            item.TypeId = itemTypeId;
            Console.WriteLine("Please enter id for new item:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();

            //item.Id = itemId;
            item.Name = name;

            Items.Add(item);
            return itemId;
        }

        public int AddNewItem(char itemType, int id)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);
            Item item = new Item(1, "");
            item.TypeId = itemTypeId;
            Console.WriteLine("Podaj nazwisko nowego wolontariusza:");
            var name = Console.ReadLine();

            //item.Id = id;
            item.Name = name;

            Items.Add(item);
            return id;
        }

        public int RemoveItemView()
        {
            Console.WriteLine("Podaj identyfikator wolontariusza, którego chcesz usunąć:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            return id;
        }

        public void RemoveItem(int removeId)
        {
            Item productToRemove = new Item(1, "");
            foreach (var item in Items)
            {
                if (item.Id == removeId)
                {
                    productToRemove = item;
                    break;
                }
            }
            Items.Remove(productToRemove);
        }


    }
}
