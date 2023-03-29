using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal static class Item_Database
    {
        // variables to easily adjust price
        static int woodPrice = 2;
        static int GoldPrice = 10;
        static int StonePrice = 5;
        static int IronPrice = 7;
        static int DiamondPrice = 12;
        static int NetheritePrice = 15;

        // instantiate all possible items to use for later
        public static List<Item> allPosibleItems = new List<Item>()
        {
            new Item("Wooden Sword", 4, woodPrice),
            new Item("Gold Sword", 4, GoldPrice),
            new Item("Stone Sword", 5, StonePrice),
            new Item("Iron Sword", 6, IronPrice),
            new Item("Diamond Sword", 7, DiamondPrice),
            new Item("Netherite Sword", 8, NetheritePrice), // 6

            new Item("Wooden Pickaxe", 2, woodPrice),
            new Item("Gold Pickaxe", 2, GoldPrice),
            new Item("Stone Pickaxe", 3, StonePrice),
            new Item("Iron Pickaxe", 4, IronPrice),
            new Item("Diamond Pickaxe", 5, DiamondPrice),
            new Item("Netherite Pickaxe", 6, NetheritePrice),// 12

            new Item("Wooden Pickaxe", 2, woodPrice),
            new Item("Gold Pickaxe", 2, GoldPrice),
            new Item("Stone Pickaxe", 3, StonePrice),
            new Item("Iron Pickaxe", 4, IronPrice),
            new Item("Diamond Pickaxe", 5, DiamondPrice),
            new Item("Netherite Pickaxe", 6, NetheritePrice),// 18

            new Item("Elytra", 0, 20),
            new Item("Shield", 0, 5),  // 20
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
