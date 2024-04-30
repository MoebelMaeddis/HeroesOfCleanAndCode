using HeroesOfCleanAndCode.Model.Terrains;
using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Assets.Images;
using HeroesOfCleanAndCode.Model.Structures;
using HeroesOfCleanAndCode.View.Map;
using System.Collections.Generic;
using System.Windows.Media;
using System;
using HeroesOfCleanAndCode.Model.Entities;
using HeroesOfCleanAndCode.Model.Helper;


namespace HeroesOfCleanAndCode.Controller.Map
{
    public class MapController
    {
        public MapCell[,] mapCells;
        public readonly int mapSizeX, mapSizeY;
        private readonly Dictionary<int, Brush> playerColors;

        private readonly Dictionary<Type, ImageSource> typesToImage = new()
        {
            {typeof(Forest), Images.Forest},
            {typeof(Grass), Images.Grass},
            {typeof(Mountain), Images.Mountain},
            {typeof(Ore), Images.Ore},
            {typeof(River), Images.River},
            {typeof(Water), Images.Water},

            {typeof(Artillery), Images.Artillery},
            {typeof(Aviated), Images.Aviated},
            {typeof(Builder), Images.Builder},
            {typeof(Heavy), Images.Heavy},
            {typeof(Infantery), Images.Infantery},
            {typeof(Medic), Images.Medic},

            {typeof(City), Images.City},
        };

        public MapView View { get; private set; }

        public MapController(MapView view)
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;

            playerColors = InitPlayerColors();

            mapSizeY = (int)game.map.mapSize;
            mapSizeX = mapSizeY * (int)game.map.mapRelation;

            mapCells = InitMapCells(game.map.terrainMap);
            UpdateMap(game);

            View = view;
        }

        public MapCell[,] InitMapCells(Terrain[,] terrain)
        {
            MapCell[,] cells = new MapCell[mapSizeX, mapSizeY];

            for (int y = 0; y < mapSizeY; y++)
            {
                for (int x = 0; x < mapSizeX; x++)
                {
                    MapCell cell = new MapCell();
                    cell.terrainImage.Source = typesToImage[terrain[x, y].GetType()];
                    cells[x, y] = cell;
                }
            }
            return cells;
        }

        public Dictionary<int, Brush> InitPlayerColors()
        {
            Random random = new Random();

            Globals globals = Globals.Instance();
            int numberOfPlayers = globals.game.players.Length;

            Dictionary<int, Brush> colorDict = new Dictionary<int, Brush>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Brush color = new SolidColorBrush(Color.FromRgb(
                        (byte)random.Next(1, 255),
                        (byte)random.Next(1, 255),
                        (byte)random.Next(1, 233)));

                colorDict.Add(i, color);
            }
            return colorDict;
        }

        public void UpdateMap(Game game)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                for (int x = 0; x < mapSizeX; x++)
                {
                    mapCells[x, y].ClearCell();
                }
            }

            for (int i = 0; i < game.players.Length; i++)
            {
                for(int j = 0; j < game.players[i].entities.Count; j++)
                {
                    Position position = new Position(
                        game.players[i].entities[j].position.x,
                        game.players[i].entities[j].position.y);

                    mapCells[position.x, position.y].entityColor = playerColors[i];
                    mapCells[position.x, position.y].entityImage.Source = typesToImage[game.players[i].entities[j].GetType()];
                }

                for (int j = 0; j < game.players[i].structures.Count; j++)
                {
                    Position position = new Position(
                        game.players[i].entities[j].position.x,
                        game.players[i].entities[j].position.y);

                    mapCells[position.x, position.y].structureColor = playerColors[i];
                    mapCells[position.x, position.y].structureImage.Source = typesToImage[game.players[i].structures[j].GetType()];
                }
            }
        }
    }
}
