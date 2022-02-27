using System;

namespace LuckySteps_Gurgen_
{
    class Start
    {
        User _user = new User();
        Game _game = new Game();
        public void StartGame()
        {
            _game.CreateTable();
            Console.Write("Please input your Name:");
            string username = Console.ReadLine();
            _user.Name = username;
            Console.WriteLine("You have two tables, one has money and the other is empty,Please chosse, start the game you good luck");
            for (int step = 0; step < 10; step++)
            {
                Console.WriteLine("Step=" + step);
                Console.WriteLine("\nPlease chosse L (left table)");
                Console.WriteLine("Please chosse R (right table)");
                Console.WriteLine("Please chosse S (stop game)");
                char choose = Convert.ToChar(Console.ReadLine());
                Validation(choose);
                switch (choose)
                {
                    case 'R':
                        {
                            _user.Amount = LeftTable(step);
                            break;
                        }
                    case 'L':
                        {
                            _user.Amount = RightTable(step);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("congratulations you won ");
                            Console.WriteLine("WonAmount=" + _user.WonAmount);
                            break;
                        }
                }
                if (_user.Amount != 0)
                {
                    Console.WriteLine("The answer is correct");
                    _user.WonAmount += _user.Amount;
                    Console.WriteLine("Amount=" + _user.Amount);
                    Console.WriteLine("WonAmount=" + _user.WonAmount);
                }
                else { _user.WonAmount = 0; Console.WriteLine("The answer is not correct WonAmount=" + _user.WonAmount); break; }
            }
            Console.WriteLine("Your Table is:");
            new ShowInfo().PrintTable(_game.left);
            new ShowInfo().PrintTable(_game.right);

        }
        public void Validation(char chosse)
        {
            while (chosse != 'L' && chosse != 'R' && chosse != 'S')
            {
                Console.WriteLine("Invalid chosse");
                Console.WriteLine("Please chosse L (left table)");
                Console.WriteLine("Please chosse R (right table)");
                Console.WriteLine("Please chosse S (stop game)");
                chosse = Convert.ToChar(Console.ReadLine());
            }
        }

        public int LeftTable(int step)
        {
            return _game.left[step];
        }
        public int RightTable(int step)
        {
            return _game.right[step];
        }



    }
}
