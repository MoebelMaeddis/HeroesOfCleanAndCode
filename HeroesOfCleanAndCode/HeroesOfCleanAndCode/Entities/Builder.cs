namespace HeroesOfCleanAndCode
{
    class Builder : Entity
    {
        public Builder(Position position) : base(position)
        {
            maxHitPoints = 30;
            currentHitPoints = maxHitPoints;
            cost = 20;
            damage = 10;

            mobility = 3;
            radius = 1;
        }
    }
}
