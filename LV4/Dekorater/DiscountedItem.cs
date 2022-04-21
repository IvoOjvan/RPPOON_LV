using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountRate = 0.3;

        public DiscountedItem(IRentable rentable) : base(rentable) { }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() - (base.CalculatePrice() * DiscountRate);
        }

        public override string Description 
        {
            get 
            {
                return base.Description + $" now at {DiscountRate * 100}% off!";
            }
        }
    }
}
