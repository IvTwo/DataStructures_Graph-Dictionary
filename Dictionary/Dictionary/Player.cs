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
            playerCollection.Add(key, item);
        }

        public void RemoveItem(string key)
        {
            playerCollection.Remove(key);
        }
    }
}
