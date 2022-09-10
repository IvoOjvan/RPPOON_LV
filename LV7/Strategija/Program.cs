using System;

namespace Strategija
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 1.
            double[] array = { 1, 6, -1, -8, 4, 9, 6, 45 };
            NumberSequence numberSequence = new NumberSequence(array);
            BubbleSort bubbleSort = new BubbleSort();
            numberSequence.SetSortStrategy(bubbleSort);
            numberSequence.Sort();

            Console.WriteLine(string.Join(", ", numberSequence));

            //Zadatak 2.
            numberSequence.SetSearchStrategy(new LinearSearch());
            Console.WriteLine("array contains number 6: " + numberSequence.Search(6));
        }
    }
}
