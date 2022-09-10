using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozit
{
    class ShippingService
    {
        private decimal costPerWeight;

        public ShippingService(decimal costPerWeight) 
        {
            this.costPerWeight = costPerWeight;
        }
        public decimal CalculateShippingFee(IShipable shipable) 
        {
            return (decimal)shipable.Weight * costPerWeight;
        }
    }
}
