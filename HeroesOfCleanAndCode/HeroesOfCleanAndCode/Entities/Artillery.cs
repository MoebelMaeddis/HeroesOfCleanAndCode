namespace HeroesOfCleanAndCode
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
            radius = 3;
        }
    }
}
