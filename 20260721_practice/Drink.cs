using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Drink
    {
        public int Number { get; set;}

        public string Name { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }

        public Drink(int number, string name, int price, int stock)
        {
            Number = number;
            Name = name;
            Price = price;
            Stock = stock;
        }

    }
}
