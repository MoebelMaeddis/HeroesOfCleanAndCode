using System.Collections.Generic;

namespace HeroesOfCleanAndCode
{
    class City : Structure
    {
        private List<SubStructure> subStructures { get; set; }
        public City(Position position) : base(position)
        {
            maxHitPoints = 1000;
            currentHitPoints = maxHitPoints;
            shieldPoints = 10;
            moneyIncome = 1000;
            scienceIncome = 0;
            subStructures = new List<SubStructure>();
        }
    }
}
