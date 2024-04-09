using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Terrains
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
