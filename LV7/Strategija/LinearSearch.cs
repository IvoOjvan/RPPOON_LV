using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategija
{
    class LinearSearch : SearchStrategy
    {
        public override bool Search(double[] array, double number)
        {
            for(int i = 0; i < array.Length; i++) 
            {
                if(array[i] == number) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
