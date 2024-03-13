namespace HeroesOfCleanAndCode
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
            radius = 10;
        }
    }
}
