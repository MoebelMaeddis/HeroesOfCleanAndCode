using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Terrains
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
