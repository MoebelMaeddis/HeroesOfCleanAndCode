using System.Collections.Generic;

namespace HeroesOfCleanAndCode
{
    public class Player
    {
        private int moneyBalance { get; set; }
        private int scienceBalance { get; set; }

        private List<Structure> structures { get; set; }
        private List<Entity> entities { get; set; }

        public Player(Position startPosition) 
        {
            this.moneyBalance = 100000;
            this.scienceBalance = 0;

            this.structures = new List<Structure>();
            this.structures.Add(new City(startPosition));

            this.entities = new List<Entity>();
            this.entities.Add(new Infantery(startPosition));
        }
    }
}
