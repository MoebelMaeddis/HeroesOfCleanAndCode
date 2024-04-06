namespace HeroesOfCleanAndCode
{
    class Mountain : Terrain
    {
        public Mountain()
        {
            this.buildable = false;
            this.mobilityCost = MobilityCost.Impossible;
        }
    }
}
