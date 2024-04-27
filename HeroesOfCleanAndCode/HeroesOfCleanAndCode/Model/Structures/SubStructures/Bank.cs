using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Structures.SubStructures
{
    class Bank : Structure
    {
        public Bank(Position position) : base(position)
        {
            maxHitPoints = 500;
            currentHitPoints = maxHitPoints;
            moneyIncome = 2000;
            scienceIncome = 0;
        }
    }
}
