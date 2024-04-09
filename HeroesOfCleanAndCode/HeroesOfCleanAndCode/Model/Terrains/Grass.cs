using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Terrains
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
