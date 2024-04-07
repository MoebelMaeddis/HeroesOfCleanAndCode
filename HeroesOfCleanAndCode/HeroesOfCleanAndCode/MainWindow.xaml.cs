using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeroesOfCleanAndCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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

        private Game game;
        private readonly Image[,] gridImages;

        public MainWindow()
        {
            InitializeComponent();
            game = new Game(Difficulty.Medium, 2, MapSize.Large, MapRelation.Double);
            gridImages = SetupEmptyMap();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Draw();
        }
        private void Window_KeyDown(object sender, RoutedEventArgs e)
        {

        }
        private void Window_MouseDown(object sender, RoutedEventArgs e)
        {

        }

        private Image[,] SetupEmptyMap()
        {
            int sizeY = (int)game.map.mapSize;
            int sizeX = sizeY * (int)game.map.mapRelation;
            Image[,] images = new Image[sizeX, sizeY];

            GameGrid.Columns = sizeX;
            GameGrid.Rows = sizeY;

            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    Image image = new Image { Source = Images.Empty };
                    images[x, y] = image;
                    GameGrid.Children.Add(image);
                }
            }
            return images;
        }

        private void Draw()
        {
            DrawTerrain();
        }

        private void DrawTerrain()
        {
            int sizeY = (int)game.map.mapSize;
            int sizeX = sizeY * (int)game.map.mapRelation;

            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    Type type = game.map.terrainMap[x, y].GetType();
                    gridImages[x, y].Source = terrainToImage[type];
                }
            }
        }
    }
}
