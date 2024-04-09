using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Entities
{
    class Infantery : Entity
    {
        public Infantery(Position position) : base(position)
        {
            maxHitPoints = 100;
            currentHitPoints = maxHitPoints;
            cost = 10;
            damage = 30;

            mobility = 3;
            radius = 1;
        }
    }
}
