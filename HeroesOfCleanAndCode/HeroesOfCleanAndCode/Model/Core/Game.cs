using HeroesOfCleanAndCode.Model.Enums;
using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Core
{
    public class Game
    {
        private Difficulty difficulty { get; set; }
        public Map map { get; protected set; }
        public Player[] players { get;  protected set; }

        public Game(Difficulty difficulty, int numberOfPlayers, MapSize mapSize, MapRelation mapRelation)
        {
            this.difficulty = difficulty;
            this.map = new Map(mapSize, mapRelation);

            this.players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Position startPosition = new Position(mapSize, mapRelation);

                this.players[i] = new Player(startPosition);
            }
        }
    }
}
 