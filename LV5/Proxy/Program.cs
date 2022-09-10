using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 3.
            const string filePath = @"E:\RPPOON\Git_LV\RPPOON_LV\LV5\Proxy\bin\Debug\netcoreapp3.1\sensitiveData.csv";
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset(filePath);
            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(User.GenerateUser("pero"));

            DataConsolePrinter consolePrinter = new DataConsolePrinter();
            consolePrinter.PrintData(virtualProxy);

            Console.WriteLine();
            consolePrinter.PrintData(protectionProxy);

            //Zadatak 4.

        }
    }
}
