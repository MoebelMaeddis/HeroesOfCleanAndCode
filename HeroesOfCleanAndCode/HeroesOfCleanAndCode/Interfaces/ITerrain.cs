using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Interfaces
{
    interface ITerrain
    {
        bool buildable { get; }
        MobilityCost mobilityCost { get; }
    }
}
