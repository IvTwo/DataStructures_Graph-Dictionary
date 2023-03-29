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
        private Dictionary<string, Item> playerCollection;

        public Player(int c)    // constructor (coins)
        {
            this.coins = c;
            playerCollection = new Dictionary<string, Item>();
        }

        // getters
        public int GetCoins()
        {
            return coins;
        }

        public bool SubtractCoins(int num)
        {
            if (coins - num < 0)
            {
                Console.WriteLine("---");
                Console.WriteLine("Insufficient Funds!");
                return false;
            }
            else
            {
                coins -= num;
                return true;
            }
        }

        public void DisplayCoins()
        {
            Console.WriteLine("You have {0} coins remaining.", coins);
        }

        public void AddItem(string key, Item item)
        {
            // if the item is already in the players collection just increase that item's quantity
            if (playerCollection.ContainsKey(key))
            {
                playerCollection[key].ChangeQuantity(1);
            }
            // otherwise add item to collection
            else
            {
                playerCollection.Add(key, item);
            }
        }

        public void RemoveItem(string key)
        {
            playerCollection.Remove(key);
        }

        public void DisplayCollection()
        {
            Console.WriteLine("---");
            Console.WriteLine("Current Player Inventory");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(string.Format("  {0,-2} | {1,-18} | {2,-10} | {3,-5}", "#", "Item Name", "Item Power", "Item Price"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in playerCollection.Values)
            {
                Console.WriteLine(string.Format("  {0,-2} | {1,-18} | {2,-10} | {3,-5}",
                                                item.GetQuantity(), item.GetName(), item.GetPower(), item.GetPrice()));
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
