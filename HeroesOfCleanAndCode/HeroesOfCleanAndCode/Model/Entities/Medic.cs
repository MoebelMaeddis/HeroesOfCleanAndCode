using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Entities
{
    class Medic : Entity
    {
        public Medic(Position position) : base(position)
        {
            maxHitPoints = 50;
            currentHitPoints = maxHitPoints;
            cost = 10;
            damage = 0;

            mobility = 5;
            range = 0;
        }
    }
}
