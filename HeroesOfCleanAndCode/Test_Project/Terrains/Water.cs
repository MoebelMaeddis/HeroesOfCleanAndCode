namespace HeroesOfCleanAndCode
{
    class Water : Terrain
    {
        public Water()
        {
            this.buildable = false;
            this.mobilityCost = MobilityCost.Major;
        }
    }
}
