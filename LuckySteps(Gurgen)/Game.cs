using System;
using System.Collections.Generic;

namespace LuckySteps_Gurgen_
{
    class Game : IGame
    {
        public IUser User { get; set; }
        public List<int> left { get; set; }
        public List<int> right { get; set; }
        public int Step { get; set; }

        public Game()
        {
            User = new User();
            left = new List<int>();
            right = new List<int>();
            Step = 1;

        }
        public void CreateTable()
        {
            int amount = 200;
            int i = 1;
            Random random = new Random();
            do
            {
                int randomNumber = random.Next();
                if (randomNumber % 2 == 0)
                {
                    left.Add(amount);
                    right.Add(0);
                    amount *= 2;
                    i++;
                }
                else
                {
                    left.Add(0);
                    right.Add(amount);
                    amount *= 2;
                    i++;
                }
            } while (i <= 10);


        }
    }
}
