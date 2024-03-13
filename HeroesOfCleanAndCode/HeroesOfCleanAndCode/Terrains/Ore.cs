namespace HeroesOfCleanAndCode
{
    class Ore : Terrain
    {
        public Ore()
        {
            this.buildable = true;
            this.mobilityCost = MobilityCost.Minor;
        }
    }
}
