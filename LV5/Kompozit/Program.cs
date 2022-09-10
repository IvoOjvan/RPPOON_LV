using System;

namespace Kompozit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 1.
            Box box = new Box("Box1");
            box.Add(new Product(4.55, "Packet1", 2));
            box.Add(new Product(5, "Packet2", 3));

            decimal costPerWeight = 1.25M;
            ShippingService shippingService = new ShippingService(costPerWeight);
            Console.WriteLine(shippingService.CalculateShippingFee(box));
        }
    }
}
