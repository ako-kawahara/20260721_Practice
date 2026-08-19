using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
