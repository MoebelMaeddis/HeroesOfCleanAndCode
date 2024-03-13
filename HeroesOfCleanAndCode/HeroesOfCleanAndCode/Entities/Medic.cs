namespace HeroesOfCleanAndCode
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
            radius = 0;
        }
    }
}
