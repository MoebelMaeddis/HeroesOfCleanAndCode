using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    public class MainWindow : Window
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

        public Dictionary<string, Label> statsLabel = new Dictionary<string, Label>();
        public Image[,] gridImages;

        public MainWindow()
        {
            SetupWindow();

            //CallGameSetupWindow

            Game game = new Game(Difficulty.Easy, 2, MapSize.Small, MapRelation.Double);

            Grid mainGrid = SetupMainGrid();
            SetColAndRowDefinitions(mainGrid, 1, 2);
            Content = mainGrid;

            UniformGrid gameGrid = SetupGameGrid(game.map.mapSize, game.map.mapRelation);
            gameGrid.SetValue(Grid.RowProperty, 0);
            mainGrid.Children.Add(gameGrid);

            UniformGrid statsGrid = SetupStatsGrid();
            statsGrid.SetValue(Grid.RowProperty, 1);
            mainGrid.Children.Add(statsGrid);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Window_KeyDown(object sender, RoutedEventArgs e)
        {

        }
        private void Window_MouseDown(object sender, RoutedEventArgs e)
        {

        }


        private void SetupWindow()
        {
            SetupWindowSize();
        }

        private void SetupWindowSize()
        {
            this.Width = (int)System.Windows.SystemParameters.PrimaryScreenWidth - 200;
            this.Height = (int)System.Windows.SystemParameters.PrimaryScreenHeight - 200;
        }


        private Grid SetupMainGrid()
        {
            Grid grid = new Grid();
            for (int i = 0; i < 2; i++) grid.RowDefinitions.Add(new RowDefinition());

            return grid;
        }


        private UniformGrid SetupGameGrid(MapSize mapSize, MapRelation mapRelation)
        {
            UniformGrid gameGrid = new UniformGrid();

            gameGrid.HorizontalAlignment = HorizontalAlignment.Center;
            gameGrid.VerticalAlignment = VerticalAlignment.Center;

            SetupEmptyGrid(gameGrid, mapSize, mapRelation);

            return gameGrid;
        }

        private void SetupEmptyGrid(UniformGrid gameGrid, MapSize mapSize, MapRelation mapRelation)
        {
            int sizeY = (int)mapSize;
            int sizeX = sizeY * (int)mapRelation;

            Image[,] images = new Image[sizeX, sizeY];

            gameGrid.Columns = sizeX;
            gameGrid.Rows = sizeY;

            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    Image image = new Image { Source = Images.Empty, Stretch = Stretch.Uniform };
                    images[x, y] = image;
                    gameGrid.Children.Add(image);
                }
            }
            gridImages = images;
        }

        private UniformGrid SetupStatsGrid()
        {
            UniformGrid statsGrid = new UniformGrid();

            statsGrid.Columns = 3;
            statsGrid.Rows = 2;

            Label activeEntityNameLabel = CreateStatsLabel("Name");
            statsGrid.Children.Add(activeEntityNameLabel);

            Label activeEntityHpLabel = CreateStatsLabel("Hp");
            statsGrid.Children.Add(activeEntityHpLabel);

            Label activeEntityMobilityLabel = CreateStatsLabel("Mobility");
            statsGrid.Children.Add(activeEntityMobilityLabel);

            Button activeEntityLevelUpButton = CreateStatsButton("LevelUp");
            statsGrid.Children.Add(activeEntityLevelUpButton);

            Label activeEntitySpLabel = CreateStatsLabel("Sp");
            statsGrid.Children.Add(activeEntitySpLabel);

            Label activeEntityRangeLabel = CreateStatsLabel("Range");
            statsGrid.Children.Add(activeEntityRangeLabel);

            return statsGrid;
        }

        private Label CreateStatsLabel(string name)
        {
            Label label = new Label();
            
            label.Content = name;
            
            label.Margin = new Thickness(20);
            label.Padding = new Thickness(20);
            
            label.Background = new SolidColorBrush(Colors.LightGray);
            label.Foreground = new SolidColorBrush(Colors.Black);

            label.BorderBrush = new SolidColorBrush(Colors.Gray);
            label.BorderThickness = new Thickness(2);

            statsLabel.Add(name, label);

            return label;
        } //Relocate

        private Button CreateStatsButton(string name)
        {
            Button button = new Button();

            button.Content = name;
            button.Margin = new Thickness(20, 20, 20, 20);
            button.Background = new SolidColorBrush(Colors.LightGray);
            button.Foreground = new SolidColorBrush(Colors.Black);
            button.BorderBrush = new SolidColorBrush(Colors.Gray);
            button.BorderThickness = new Thickness(2);

            return button;
        } //Relocate

        private void SetColAndRowDefinitions(Grid grid, int sizeX, int sizeY)
        {
            for (int x = 0; x < sizeX; x++) grid.ColumnDefinitions.Add(new ColumnDefinition());
            for (int y = 0; y < sizeY; y++) grid.RowDefinitions.Add(new RowDefinition());
        } //Relocate


        public void Draw(Map map)
        {
            DrawTerrain(map);
        }

        public void DrawTerrain(Map map)
        {
            int sizeY = (int)map.mapSize;
            int sizeX = sizeY * (int)map.mapRelation;

            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    Type type = map.terrainMap[x, y].GetType();
                    gridImages[x, y].Source = terrainToImage[type];
                }
            }
        }


        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new MainWindow());
        }
    }
}
