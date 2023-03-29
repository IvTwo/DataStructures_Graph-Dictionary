using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Shop
    {
        private Dictionary<string, Item> shopInventory;

        public Shop(int q)    // constructor (coins, #starting items)
        {
            shopInventory = new Dictionary<string, Item>();
            this.StartingInventory(q);
        }

        // fill Shop inventory with X(numOfItems) items
        public void StartingInventory(int numOfItems)
        {
            var rand = new Random();

            for(int i = 0; i < numOfItems; i++)
            {
                int randNum = rand.Next(0,Item_Database.allPosibleItems.Count);   // generate rand num between 0 and all possible item count

                string itemName = Item_Database.allPosibleItems[randNum].GetName();

                // if the item is already in the players inventory just increase that item's quantity
                if (shopInventory.ContainsKey(itemName))
                {
                    shopInventory[itemName].IncreaseQuantity();
                }
                // otherwise add item to shop inventory
                else
                {
                    shopInventory.Add(itemName, Item_Database.allPosibleItems[randNum]);
                }
            }
        }

        // ref: https://www.csharp-examples.net/align-string-with-spaces/
        public void DisplayInventory()
        {
            Console.WriteLine("---");
            Console.WriteLine("Current Shop Inventory");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(string.Format("  {0,-2} | {1,-18} | {2,-10} | {3,-5}","#", "Item Name", "Item Power", "Item Price"));
            Console.WriteLine("---------------------------------------------------");
            foreach(var item in shopInventory.Values)
            {
                Console.WriteLine(string.Format("  {0,-2} | {1,-18} | {2,-10} | {3,-5}",
                                                item.GetQuantity(), item.GetName(), item.GetPower(), item.GetPrice()));
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
