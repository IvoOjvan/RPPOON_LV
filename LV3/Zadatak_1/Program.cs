using System;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"E:\RPPOON\LV3\Zadatak_1\bin\Debug\netcoreapp3.1\zad1.txt";
            Dataset dataset = new Dataset(filePath);

            Console.WriteLine(dataset);

            Dataset clone = (Dataset)dataset.Clone();
            Console.WriteLine(clone);
        }
    }
}
