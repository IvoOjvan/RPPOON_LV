using System;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            int numberOfSides = 6;

            for(int i = 0; i < 20; i++) 
            {
                diceRoller.InsertDie(new Die(numberOfSides));
            }

            diceRoller.RollAllDice();
            foreach(int rollResult in diceRoller.GetRollingResults()) 
            {
                Console.WriteLine(rollResult);
            }
        }
    }
}
