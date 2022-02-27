namespace LuckySteps_Gurgen_
{
    class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int WonAmount { get; set; }
        public char Chose { get; set; }
        public bool choseValid { get; set; }

        public User()
        {
            Id = 1;
            Amount = 0;
            WonAmount = 0;
            choseValid = true;
        }
    }
}
