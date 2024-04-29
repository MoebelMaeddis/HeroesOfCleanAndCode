using HeroesOfCleanAndCode.Model.Terrains;
using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Assets.Images;
using HeroesOfCleanAndCode.View.Map;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System;


namespace HeroesOfCleanAndCode.Controller.Map
{
    public class MapController
    {
        public readonly Image[,] mapImages;
        public Image[,] entityImages;
        public readonly int mapSizeX, mapSizeY;

        private readonly Dictionary<Type, ImageSource> terrainToImage = new()
        {
            {typeof(Forest), Images.Forest},
            {typeof(Grass), Images.Grass},
            {typeof(Mountain), Images.Mountain},
            {typeof(Ore), Images.Ore},
            {typeof(River), Images.River},
            {typeof(Water), Images.Water},
        };
        public MapView View { get; private set; }

        public MapController(MapView view)
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;

            mapSizeY = (int)game.map.mapSize;
            mapSizeX = mapSizeY * (int)game.map.mapRelation;

            mapImages = InitMapImages();

            View = view;
        }

        public Image[,] InitMapImages()
        {
            Image[,] images = new Image[mapSizeX, mapSizeY];

            for (int y = 0; y < mapSizeY; y++)
            {
                for (int x = 0; x < mapSizeX; x++)
                {
                    Image image = new Image
                    {
                        Source = Images.Empty,
                    };
                    images[x, y] = image;
                }
            }
            return images;
        }

        public void InitEntityImages()
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;


        }

        public void UpdateMap()
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;

            for (int y = 0; y < mapSizeY; y++)
            {
                for (int x = 0; x < mapSizeX; x++)
                {
                    mapImages[x, y].Source = terrainToImage[game.map.terrainMap[x, y].GetType()];
                }
            }
        }
    }
}
