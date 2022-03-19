using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    interface IStoreable
    {
        public void InsertDie(Die die);
        public void RemoveAllDice();
    }
}
