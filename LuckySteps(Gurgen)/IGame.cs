using System.Collections.Generic;

namespace LuckySteps_Gurgen_
{
    interface IGame
    {
        IUser User { get; set; }
        List<int> left { set; get; }
        List<int> right { set; get; }
        int Step { get; set; }
    }
}
