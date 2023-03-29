using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Player
    {
        private int coins;
        private Dictionary<string, Item> playerInventory;

        public Player(int c, int q)    // constructor (coins, #starting items)
        {
            coins = c;
            playerInventory = new Dictionary<string, Item>();
            this.StartingInventory(q);
        }

        // fill players inventory with X(numOfItems) items
        public void StartingInventory(int numOfItems)
        {
            var rand = new Random();

            for(int i = 0; i < numOfItems; i++)
            {
                int randNum = rand.Next(0,Central_Inventory.allPosibleItems.Count);   // generate rand num between 0 and all possible item count

                string itemName = Central_Inventory.allPosibleItems[randNum].GetName();

                // if the item is already in the players inventory just increase that item's quantity
                if (playerInventory.ContainsKey(itemName))
                {
                    playerInventory[itemName].IncreaseQuantity();
                }
                // otherwise add item to player inventory
                else
                {
                    playerInventory.Add(itemName, Central_Inventory.allPosibleItems[randNum]);
                }
            }
        }

        // ref: https://www.csharp-examples.net/align-string-with-spaces/
        public void DisplayInventory()
        {
            Console.WriteLine("---");
            Console.WriteLine("Current Player Inventory");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(string.Format("  {0,-2} | {1,-18} | {2,-10} | {3,-5}","#", "Item Name", "Item Power", "Item Price"));
            Console.WriteLine("---------------------------------------------------");
            foreach(var item in playerInventory.Values)
            {
                Console.WriteLine(string.Format("  {0,-2} | {1,-18} | {2,-10} | {3,-5}",
                                                item.GetQuantity(), item.GetName(), item.GetPower(), item.GetPrice()));
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
