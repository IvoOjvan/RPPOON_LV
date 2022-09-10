using System;

namespace Promatrač
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider provider = new SystemDataProvider();
            ConsoleLogger logger = new ConsoleLogger();

            for(; ; ) 
            {
                provider.GetAvailableRAM();
                provider.GetCPULoad();
                logger.Log(provider);
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
