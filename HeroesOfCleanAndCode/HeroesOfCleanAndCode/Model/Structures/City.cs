using System.Collections.Generic;
using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Structures
{
    class City : Structure
    {
        private List<Structure> subStructures { get; set; }
        public City(Position position) : base(position)
        {
            maxHitPoints = 1000;
            currentHitPoints = maxHitPoints;
            shieldPoints = 10;
            moneyIncome = 1000;
            scienceIncome = 0;
            subStructures = new List<Structure>();
        }
    }
}
