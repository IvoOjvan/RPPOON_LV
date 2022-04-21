using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {

            int columnCount = 0;
            for(int i = 0; i < data.Length; i++) 
            {
                if (data[i].Length > columnCount) columnCount = data[i].Length;
            }
            double[] results = new double[columnCount];

            for(int i = 0; i < columnCount; i++) 
            {
                double columnSum = 0.0;
                int columnElementsCount = 0;
                for(int j = 0; j < data.Length; j++) 
                {
                    if (i < data[j].Length)
                    {
                        columnSum += data[j][i];
                        columnElementsCount++;
                    }
                }
                results[i] = columnSum / columnElementsCount;
            }

            return results;
        }
    }
}
