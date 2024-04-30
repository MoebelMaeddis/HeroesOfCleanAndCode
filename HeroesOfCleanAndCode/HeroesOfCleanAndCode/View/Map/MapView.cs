using static HeroesOfCleanAndCode.Controller.Map.MapController;
using HeroesOfCleanAndCode.Controller.Map;
using HeroesOfCleanAndCode.Interfaces;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Controls.Primitives;
using System.Windows;

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

        public void Update()
        {
            Controller.UpdateMapView();

            //UpdateMapCells();
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
            InitMapCells();
        }

        public void InitMapCells()
        {

            for (int y = 0; y < Controller.mapSizeY; y++)
            {
                for (int x = 0; x < Controller.mapSizeX; x++)
                {
                    Border cellBorder = new Border()
                    {
                        BorderThickness = new Thickness(2),
                        BorderBrush = Controller.mapCells[x, y].cellBorderColor,
                        Background = new ImageBrush(Controller.mapCells[x, y].terrainImage.Source),
                    };

                    Border entityBorder = new Border()
                    {
                        Height = 10,
                        Width = 20,
                        BorderThickness = new Thickness(1),
                        Background = new ImageBrush(Controller.mapCells[x, y].entityImage.Source),
                        BorderBrush = Controller.mapCells[x, y].entityColor,
                    };

                    Border structureBorder = new Border()
                    {
                        Height = 10,
                        Width = 20,
                        BorderThickness = new Thickness(1),
                        Background = new ImageBrush(Controller.mapCells[x, y].structureImage.Source),
                        BorderBrush = Controller.mapCells[x, y].structureColor,
                    };

                    StackPanel content = new StackPanel();
                    content.VerticalAlignment = VerticalAlignment.Bottom;
                    content.Orientation = Orientation.Horizontal;
                    content.Children.Add(entityBorder);
                    content.Children.Add(structureBorder);

                    cellBorder.Child = content;
                    this.Children.Add(cellBorder);
                }
            }
        }

        public void UpdateMapCells()
        {

            for (int y = 0; y < Controller.mapSizeY; y++)
            {
                for (int x = 0; x < Controller.mapSizeX; x++)
                {


                    Border cellBorder = new Border()
                    {
                        BorderThickness = new Thickness(2),
                        BorderBrush = Controller.mapCells[x, y].cellBorderColor,
                        Background = new ImageBrush(Controller.mapCells[x, y].terrainImage.Source),
                    };

                    Border entityBorder = new Border()
                    {
                        Height = 10,
                        Width = 20,
                        BorderThickness = new Thickness(1),
                        Background = new ImageBrush(Controller.mapCells[x, y].entityImage.Source),
                        BorderBrush = Controller.mapCells[x, y].entityColor,
                    };

                    Border structureBorder = new Border()
                    {
                        Height = 10,
                        Width = 20,
                        BorderThickness = new Thickness(1),
                        Background = new ImageBrush(Controller.mapCells[x, y].structureImage.Source),
                        BorderBrush = Controller.mapCells[x, y].structureColor,
                    };

                    StackPanel content = new StackPanel();
                    content.VerticalAlignment = VerticalAlignment.Bottom;
                    content.Orientation = Orientation.Horizontal;
                    content.Children.Add(entityBorder);
                    content.Children.Add(structureBorder);

                    cellBorder.Child = content;
                    this.Children.Add(cellBorder);
                }
            }
        }
    }
}
