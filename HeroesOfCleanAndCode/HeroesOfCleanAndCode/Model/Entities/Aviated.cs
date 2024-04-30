using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Entities
{
    class Aviated : Entity
    {
        public Aviated(Position position) : base(position)
        {
            maxHitPoints = 50;
            currentHitPoints = maxHitPoints;
            cost = 50;
            damage = 140;

            mobility = 15;
            range = 10;
        }
    }
}
