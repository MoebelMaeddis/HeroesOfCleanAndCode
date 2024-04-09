using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Terrains
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
