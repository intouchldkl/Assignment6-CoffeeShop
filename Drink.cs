using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_CoffeeShop
{
    class Drink
    {
        private string name;  //tea coffee juice
        private int price;   //45      50   30

        public Drink(string name)
        {
            this.name = name;
            if (name == "coffee") price = 50;
            if (name == "tea") price = 45;
            if (name == "juice") price = 30;
          
        }
        public string GetName()
        {
            return name;
        }
        public int GetPrice()
        {
            return price;
        }
    }
}
