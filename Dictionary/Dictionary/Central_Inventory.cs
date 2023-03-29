using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal static class Central_Inventory
    {
        // instantiate all possible items to use for later
        public static List<Item> allPosibleItems = new List<Item>()
        {
            new Item("Wooden Sword", 4, 5),
            new Item("Gold Sword", 4, 15),
            new Item("Stone Sword", 5, 7),
            new Item("Iron Sword", 6, 10),
            new Item("Diamond Sword", 7, 10),
            new Item("Netherite Sword", 8, 20), // 6

            new Item("Wooden Pickaxe", 2, 5),
            new Item("Gold Pickaxe", 2, 15),
            new Item("Stone Pickaxe", 3, 7),
            new Item("Iron Pickaxe", 4, 10),
            new Item("Diamond Pickaxe", 5, 10),
            new Item("Netherite Pickaxe", 6, 20),// 12

            new Item("Wooden Pickaxe", 2, 5),
            new Item("Gold Pickaxe", 2, 15),
            new Item("Stone Pickaxe", 3, 7),
            new Item("Iron Pickaxe", 4, 10),
            new Item("Diamond Pickaxe", 5, 10),
            new Item("Netherite Pickaxe", 6, 20),// 18

            new Item("Elytra", 0, 20),
            new Item("Shield", 0, 10),  // 20
        };

        // instantiate items into a dictionary
        public static Dictionary<string, Item> itemDictionary = new Dictionary<string, Item>();
        public static void fillDictionary()
        {
            foreach (var item in allPosibleItems) 
            {
                itemDictionary.Add(item.GetName(), item);
            }
        }
    }
}
