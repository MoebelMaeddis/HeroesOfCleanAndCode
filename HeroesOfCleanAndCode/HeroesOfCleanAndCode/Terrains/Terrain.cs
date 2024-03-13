namespace HeroesOfCleanAndCode
{
    public abstract class Terrain : ITerrain
    {
        public bool buildable { get; protected set; }
        public MobilityCost mobilityCost { get; protected set; }
        protected Terrain() { }
    }
}
