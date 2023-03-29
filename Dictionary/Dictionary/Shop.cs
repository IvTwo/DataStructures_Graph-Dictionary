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

                // if the item is already in the shop inventory just increase that item's quantity
                if (shopInventory.ContainsKey(itemName))
                {
                    shopInventory[itemName].ChangeQuantity(1);
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

        public void BuyItem(string itemName, ref Player player)
        {
            if (!shopInventory.ContainsKey(itemName))   // make sure item is in shop inventory
            {
                Console.WriteLine("---");
                Console.WriteLine("Item not in shop inventory.");
                return;
            }

            // if player has sufficient funds, add item to player collection and delete one from shop inventory
            if (player.SubtractCoins(shopInventory[itemName].GetPrice()))
            {
                player.AddItem(shopInventory[itemName].GetName(), shopInventory[itemName].returnItem());

                shopInventory[itemName].ChangeQuantity(-1);
                if (shopInventory[itemName].GetQuantity() <= 0) // if an item quantity is 0, remove it from the shop inventory
                {
                    shopInventory.Remove(itemName);
                }

                Console.WriteLine();
                Console.WriteLine("You bought {0}.", itemName);
            }

            // tell player how many coins they have remaining
            Console.WriteLine();
            player.DisplayCoins();
        }

        public void SellItem(string itemName, ref Player player)
        {
            if (!player.CheckCollection(itemName))
            {
                Console.WriteLine("---");
                Console.WriteLine("Item not in player collection.");
                return;
            }

            // add coins and remove item from player collection
            player.AddCoins(player.GetItem(itemName).GetPrice());
            player.RemoveItem(itemName);
            Console.WriteLine();
            Console.WriteLine("You sold {0}.", itemName);

            Console.WriteLine();
            player.DisplayCoins();
        }
    }
}
