using static HeroesOfCleanAndCode.Controller.Map.MapController;
using HeroesOfCleanAndCode.Controller.Map;
using HeroesOfCleanAndCode.Interfaces;
using System.Windows.Controls;
using System;
using HeroesOfCleanAndCode.Assets.Images;
using System.Windows.Media;
using System.Windows.Controls.Primitives;
using System.Windows;
using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.View.Map
{

    public class MapView : UniformGrid, IView
    {
        public MapController Controller { get; private set; }

        public MapView()
        {
            Controller = new MapController(this);

            InitLayout();
        }

        public void InitLayout()
        {
            InitGrid();

            InitMap();
        }

        private void InitGrid()
        {
            Width = 1700;
            Height = 850;

            Rows = Controller.mapSizeY;
            Columns = Controller.mapSizeX;
            
            Background = Brushes.LightGray;
            SnapsToDevicePixels = true;
            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.HighQuality);

            Style imageStyle = new Style(typeof(Image));
            imageStyle.Setters.Add(new Setter(Image.MarginProperty, new Thickness(1)));
            Resources.Add(typeof(Image), imageStyle);
        }

        void InitMap()
        {
            InitMapImages();
        }

        public void InitMapImages()
        {
            Controller.UpdateMap();

            for (int y = 0; y < Controller.mapSizeY; y++)
            {
                for (int x = 0; x < Controller.mapSizeX; x++)
                {
                    this.Children.Add(
                        new Border() {
                            BorderThickness = new Thickness(1),
                            BorderBrush = Brushes.Black,
                            Background = new ImageBrush(Controller.mapImages[x, y].Source)
                        }
                    );
                }
            }
        }
    }
}
