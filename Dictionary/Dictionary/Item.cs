using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Item
    {
        private string name;
        private int power;
        private int price;
        private int quantity;

        public Item(string name, int power, int price)  // constructor
        {
            this.name = name;
            this.power = power;
            this.price = price;
            this.quantity = 1;
        }

        // getters
        public string GetName()
        {
            return name;
        }
        public int GetPrice()
        {
            return price;
        }
        public int GetPower()
        {
            return power;
        }
        public int GetQuantity()
        {
            return quantity;
        }

        public void IncreaseQuantity()
        {
            quantity++;
        }
    }
}
