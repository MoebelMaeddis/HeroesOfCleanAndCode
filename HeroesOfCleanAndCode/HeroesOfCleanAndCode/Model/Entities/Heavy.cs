using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Entities
{
    class Heavy : Entity
    {
        public Heavy(Position position) : base(position)
        {
            maxHitPoints = 200;
            currentHitPoints = maxHitPoints;
            cost = 40;
            damage = 90;

            mobility = 4;
            range = 1;
        }
    }
}
