using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Products
    {






        private string name;
        private Snacks snack;
        private Drinks drink;
        private int amount;
        private int price;

        public string Name { get => name; private set => name = value; }
        internal Snacks Snack { get => snack; set => snack = value; }
       
        public Drinks Drink { get => drink; private set => drink = value; }
        public int Amount { get => amount; private set => amount = value; }
        public int Price { get => price; private set => price = value; }

        public Products(string name, Drinks drink,int price)
        {
            Price = price;
            Name = name;
            Drink = new Drinks(drink.Name, drink.Ml);

        }

        public Products (string name,Snacks snack,int price)
        {
            Price = price;
            Name = name;
            Snack = new Snacks(snack.Name,snack.Gram);
        }


    }
}
