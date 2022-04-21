using System;
using System.Collections.Generic;

namespace Dekorater
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>()
            {
                new Book("Knjiga1"),
                new Video("Video1"),
            };

            RentingConsolePrinter consolePrinter = new RentingConsolePrinter();
            consolePrinter.DisplayItems(rentables);
            Console.WriteLine();

            rentables.Add(new HotItem(new Book("Hit book 1")));
            rentables.Add(new HotItem(new Video("Hit video 1")));

            consolePrinter.DisplayItems(rentables);

            Console.WriteLine();
            List<IRentable> flashSale = new List<IRentable>()
            {
                new DiscountedItem(new Book("Knjiga1")),
                new DiscountedItem(new Video("Video1")),
                new DiscountedItem(new HotItem(new Book("Hit book 1"))),
                new DiscountedItem(new HotItem(new Video("Hit video 1"))),

            };

            consolePrinter.DisplayItems(flashSale);
        }
    }
}
