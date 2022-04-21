using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    class Book : IRentable
    {
        private readonly double BaseBookPrice = 3.99;
        public String Title { get; private set; }
        public Book(String title) { this.Title = title; }
        public string Description { get { return this.Title; } }
        public double CalculatePrice() { return this.BaseBookPrice; }

    }
}
