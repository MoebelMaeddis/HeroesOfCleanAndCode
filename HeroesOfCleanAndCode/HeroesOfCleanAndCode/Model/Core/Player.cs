using System.Collections.Generic;
using HeroesOfCleanAndCode.Model.Structures;
using HeroesOfCleanAndCode.Model.Entities;
using HeroesOfCleanAndCode.Model.Helper;

namespace HeroesOfCleanAndCode.Model.Core
{
    public class Player
    {
        public int moneyBalance { get; set; }
        public int scienceBalance { get; set; }

        public List<Structure> structures { get; set; }
        public List<Entity> entities { get; set; }

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
