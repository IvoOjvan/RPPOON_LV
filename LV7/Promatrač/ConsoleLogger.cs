using System;
using System.Collections.Generic;
using System.Text;

namespace Promatrač
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            //implementation missing
            Console.WriteLine(DateTime.Now + "-> CPU load: " + provider.CPULoad + " Available RAM: " + provider.AvailableRAM);
        }
    }
}
