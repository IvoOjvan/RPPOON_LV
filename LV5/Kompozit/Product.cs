using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozit
{
    class Product : IShipable
    {
        private double price;
        private string description;
        private double weight;

        public Product(double price, string description, double weight) 
        {
            this.price = price;
            this.description = description;
            this.weight = weight;
        }

        public double Price { get { return price; } }

        public double Weight { get { return weight; } }

        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
