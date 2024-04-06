namespace HeroesOfCleanAndCode
{
    class Forest : Terrain
    {
        public Forest()
        {
            this.buildable = true;
            this.mobilityCost = MobilityCost.Medium;
        }
    }
}
