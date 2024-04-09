using System;
using System.Windows.Media;
using System.Collections.Generic;
using HeroesOfCleanAndCode.View.Map;
using HeroesOfCleanAndCode.Assets.Images;
using HeroesOfCleanAndCode.Model.Terrains;

namespace HeroesOfCleanAndCode.Controller.Map
{
    public class MapController
    {
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
            View = view;
        }
    }
}
