using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Model.Terrains
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
