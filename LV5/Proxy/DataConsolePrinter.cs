using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class DataConsolePrinter
    {
        public void PrintData(IDataset dataset) 
        {
            foreach(List<string> row in dataset.GetData()) 
            {
                foreach(string item in row) 
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
