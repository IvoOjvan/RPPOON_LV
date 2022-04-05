using System;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MatrixGenerator matrixGenerator = MatrixGenerator.GetInstance();
            const int numberOfRows = 5, numberOfColumns = 5;

            double[,] matrix = matrixGenerator.Generate(numberOfRows, numberOfColumns);

            for(int i = 0; i < numberOfRows; i++) 
            {
                for(int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write(Math.Round(matrix[i,j],2) + " ");
                }
                Console.WriteLine();
            }*/

            //Zadatak 3
            Logger logger = Logger.GetIstance();
            logger.Log("Prvi unos");

            Logger logger2 = Logger.GetIstance();
            logger2.Log("Dugi unos");



        }
    }
}
