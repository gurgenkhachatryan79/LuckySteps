namespace LuckySteps_Gurgen_
{
    interface IUser
    {
        int Id { set; get; }
        string Name { set; get; }
        int Amount { set; get; }
        int WonAmount { set; get; }
        char Chose { set; get; }
        bool choseValid { set; get; }
    }
}
