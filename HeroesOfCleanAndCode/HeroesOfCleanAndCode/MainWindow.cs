using System.Windows;
using System.Windows.Controls;
using HeroesOfCleanAndCode.View.Main;
using HeroesOfCleanAndCode.Interfaces;

namespace HeroesOfCleanAndCode
{
    public partial class MainWindow : Window, IView
    {
        private readonly Image[,] gameGridImages;
        public MainWindow()
        {
            WindowState = WindowState.Maximized;
            Title = "Heroes of Clean and Code";

            InitLayout();
        }

        public void InitLayout()
        {
            Content = new MainView();
        }
    }
}
