using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"E:\RPPOON\Git_LV\RPPOON_LV\LV4\Adapter\bin\Debug\netcoreapp3.1\testFile.csv";
            Dataset dataset = new Dataset(filePath);

            Console.WriteLine(dataset);

            Adapter adapter = new Adapter(new Analyzer3rdParty());
            Console.WriteLine(string.Join(" ", adapter.CalculateAveragePerRow(dataset)));
            Console.WriteLine(string.Join(" ", adapter.CalculateAveragePerColumn(dataset)));

        }
    }
}
