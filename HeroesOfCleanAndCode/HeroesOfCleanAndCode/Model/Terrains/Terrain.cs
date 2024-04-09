using HeroesOfCleanAndCode.Model.Enums;
using HeroesOfCleanAndCode.Interfaces;

namespace HeroesOfCleanAndCode.Model.Terrains
{
    public abstract class Terrain : ITerrain
    {
        public bool buildable { get; protected set; }
        public MobilityCost mobilityCost { get; protected set; }
        protected Terrain() { }
    }
}
