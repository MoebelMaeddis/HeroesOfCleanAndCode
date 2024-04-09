using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Structures.SubStructures
{
    class SubStructure : Structure
    {
        public SubStructure(Position position) : base(position)
        {
            shieldPoints = 0;
        }
    }
}
