﻿using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Structures.SubStructures
{
    class University : Structure
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
