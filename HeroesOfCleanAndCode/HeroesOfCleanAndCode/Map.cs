using System;

namespace HeroesOfCleanAndCode
{
    public class Map
    {
        public MapSize mapSize { get; protected set; }
        public MapRelation mapRelation { get; protected set; }
        public Terrain[,] terrainMap { get; protected set; }

        private Map() 
        {
            throw new Exception("This constructor shall not be used");
        }

        public Map(MapSize mapSize, MapRelation mapRelation)
        {
            this.mapSize = mapSize;
            this.mapRelation = mapRelation;

            this.terrainMap = CreateMap();
        }

        //Exclude from Map class?
        private Terrain[,] CreateMap()
        {
            var random = new Random();
            int sizeY = (int)this.mapSize;
            int sizeX = sizeY * (int)this.mapRelation;

            Terrain[,] terrainMap = new Terrain[sizeX, sizeY];

            Type[] terrainTypes =
            {
                typeof(Forest),
                typeof(Grass),
                typeof(Mountain),
                typeof(Ore),
                typeof(River),
                typeof(Water),
            };

            //PerlinNoise to insert here?

            for(int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    //Create a mountain barrier around the whole map, to enclosure Players.
                    Type characterType = (x == 0 || x == sizeX - 1 || y == 0 || y == sizeY - 1) ? typeof(Mountain) : terrainTypes[random.Next(terrainTypes.Length)];

                    terrainMap[x, y] = (Terrain)Activator.CreateInstance(characterType);
                }
            }
            return terrainMap;
        }
    }
}
