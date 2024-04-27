using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Structures.SubStructures
{
    class Barracs : Structure
    {
        public Barracs(Position position) : base(position)
        {
            maxHitPoints = 500;
            currentHitPoints = maxHitPoints;
            moneyIncome = -200;
            scienceIncome = 0;
        }
    }
}
