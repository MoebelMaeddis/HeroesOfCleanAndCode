namespace HeroesOfCleanAndCode
{
    class University : SubStructure
    {
        public University(Position position) : base(position)
        {
            maxHitPoints = 500;
            currentHitPoints = maxHitPoints;
            moneyIncome = -200;
            scienceIncome = 100;
        }
    }
}
