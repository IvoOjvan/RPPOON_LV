using System;
using System.Collections.Generic;
using System.Text;

namespace Strategija
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for(int i = 0; i < array.Length - 1; i++) 
            {
                for(int j = 0; j < array.Length - 1 - i; j++) 
                {
                    if(array[j] > array[j + 1]) 
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
    }
}
