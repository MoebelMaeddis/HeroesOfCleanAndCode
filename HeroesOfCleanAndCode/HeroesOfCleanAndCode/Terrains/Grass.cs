namespace HeroesOfCleanAndCode
{
    class Grass : Terrain
    {
        public Grass()
        {
            this.buildable = true;
            this.mobilityCost = MobilityCost.Minor;
        }
    }
}
