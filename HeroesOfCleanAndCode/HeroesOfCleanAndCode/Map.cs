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

            //@Yannick: I would suggest to move this to a separate class, e.g. TerrainGenerator -> Code smell: Long method / doubled code
            FastNoiseLite rawMountainNoise = new FastNoiseLite();
            rawMountainNoise.SetSeed(random.Next());
            rawMountainNoise.SetFrequency(0.03f);
            rawMountainNoise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2);

            FastNoiseLite rawHumidityNoise = new FastNoiseLite();
            rawHumidityNoise.SetSeed(random.Next());
            rawHumidityNoise.SetFrequency(0.06f);
            rawHumidityNoise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2);

            float[,] mountainNoise = new float[sizeX, sizeY];
            float[,] humidityNoise = new float[sizeX, sizeY];

            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    mountainNoise[x, y] = rawMountainNoise.GetNoise(x, y);
                    humidityNoise[x, y] = rawHumidityNoise.GetNoise(x, y);
                }
            }


            Type[] terrainTypes =
            {
                typeof(Forest),
                typeof(Grass),
                typeof(Mountain),
                typeof(Ore),
                typeof(River),
                typeof(Water),
            };


            for(int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    Type characterType;

                    //Border
                    if (x == 0 || x == sizeX - 1 || y == 0 || y == sizeY - 1) characterType = typeof(Mountain);

                    else
                    {
                        float mountainValue = mountainNoise[x, y];

                        if (mountainValue > 0.8f) characterType = typeof(Mountain);
                        else if (mountainValue > 0.7) characterType = typeof(Ore);
                        else if (mountainValue >-0.5f)
                        {
                            float humidityValue = humidityNoise[x, y];

                            if (humidityValue > 0.0f) characterType = typeof(Forest);
                            else if (humidityValue > -1.0f) characterType = typeof(Grass);
                            else characterType = typeof(Ore);
                        }
                        else if (mountainValue > -0.6f) characterType = typeof(River);
                        else characterType = typeof(Water);
                    }
                            

                    terrainMap[x, y] = (Terrain)Activator.CreateInstance(characterType);
                }
            }
            return terrainMap;
        }
    }
}
