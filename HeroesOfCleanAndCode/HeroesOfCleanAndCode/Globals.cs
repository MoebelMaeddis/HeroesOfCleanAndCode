using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode
{
    public sealed class Globals
    {
        private static Globals instance = null;
        private static readonly object padlock = new object();
        public static Game game { get; set; }

        Globals()
        {
            game = new Game(Difficulty.Easy, 2, MapSize.Tiny, MapRelation.Double);
        }

        public static Globals Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Globals();
                    }
                    return instance;
                }
            }
        }
    }
}

