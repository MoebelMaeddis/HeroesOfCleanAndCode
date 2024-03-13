namespace HeroesOfCleanAndCode
{
    class River : Terrain
    {
        public River()
        {
            this.buildable = true;
            this.mobilityCost = MobilityCost.Medium;
        }
    }
}
