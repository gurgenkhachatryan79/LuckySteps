using System;
using System.Collections.Generic;

namespace LuckySteps_Gurgen_
{
    class ShowInfo
    {
        public void PrintTable(List<int> leftOrRight)
        {
            Console.WriteLine();
            foreach (var item in leftOrRight)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
