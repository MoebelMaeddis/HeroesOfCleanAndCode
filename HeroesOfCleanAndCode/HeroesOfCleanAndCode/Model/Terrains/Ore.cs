using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Terrains
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
