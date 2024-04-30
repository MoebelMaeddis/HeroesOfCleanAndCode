using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Entities
{
    class Artillery : Entity
    {
        public Artillery(Position position) : base(position)
        {
            maxHitPoints = 80;
            currentHitPoints = maxHitPoints;
            cost = 15;
            damage = 60;

            mobility = 2;
            range = 3;
        }
    }
}
