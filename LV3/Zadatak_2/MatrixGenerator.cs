using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random random;

        private MatrixGenerator() 
        {
            this.random = new Random();
        }

        public static MatrixGenerator GetInstance() 
        {
            if(instance is null) 
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[,] Generate(int numberOfRows, int numberOfColumns) 
        {
            double[,] matrix = new double[numberOfColumns, numberOfColumns];
            for(int i = 0; i < numberOfRows; i++) 
            {
                for(int j = 0; j < numberOfColumns; j++) 
                {
                    matrix[i, j] = random.NextDouble();
                }
            }
            return matrix;
        }
    }
}
