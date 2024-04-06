namespace HeroesOfCleanAndCode
{
    interface ITerrain
    {
        bool buildable { get; }
        MobilityCost mobilityCost { get; }
    }
}
