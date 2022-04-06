using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Zadatak_1
{
    class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        private Dataset(Dataset dataset) 
        {
            List<List<string>> deepCopyList = new List<List<string>>();
            foreach (List<string> list in dataset.data)
            {
                List<string> innerList = new List<string>();
                foreach (string row in list)
                {
                    innerList.Add(row);
                }
                deepCopyList.Add(innerList);
            }

            this.data = deepCopyList;
        }

        //... code missing
        private void LoadDataFromCSV(string filePath) 
        {
            string readContent;
            int lineCount = File.ReadLines(filePath).Count();
            using(StreamReader reader = new StreamReader(filePath)) 
            {
                for(int i = 0; i < lineCount; i++) 
                {
                    List<string> row = new List<string>();
                    string readData = reader.ReadLine().Replace(","," ");
                    if(readData != string.Empty) 
                    {
                        row.Add(readData);
                        this.data.Add(row);
                    }
                }
            }
        }

        public Prototype Clone()
        {
            return new Dataset(this);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(List<string> list in this.data) 
            {
                foreach(string data in list) 
                {
                    builder.Append(data);
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
        
    }
}
