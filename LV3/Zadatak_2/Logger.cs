using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zadatak_2
{
    class Logger
    {
        private static Logger istance;
        private string filePath;

        private Logger() 
        {
            filePath = @"E:\RPPOON\LV3\Zadatak_2\bin\Debug\netcoreapp3.1\defaultFile.txt";
        }

        public static Logger GetIstance() 
        {
            if(istance is null) 
            {
                istance = new Logger();
            }
            return istance;
        }

        public void SetFilePath(string filePath) { this.filePath = filePath; }

        public void Log(string message) 
        {
            using(StreamWriter writer = new StreamWriter(filePath)) 
            {
                writer.WriteLine(message);
            }
        }
    }
}
