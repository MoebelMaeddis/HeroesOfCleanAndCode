using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode
{
    public sealed class Globals
    {
        private static Globals instance = null;
        private static readonly object padlock = new object();
        public Game game { get; set; }

        Globals() { }

        public static Globals Instance()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Globals();
                        instance.game = new Game(Difficulty.Easy, 2, MapSize.Tiny, MapRelation.Double);
                    }
                }
            }
            return instance;
        }
    }
}

