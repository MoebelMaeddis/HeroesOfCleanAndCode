using System.Windows;
using HeroesOfCleanAndCode.View.Main;
using HeroesOfCleanAndCode.Interfaces;
using HeroesOfCleanAndCode.Model.Core;

namespace HeroesOfCleanAndCode
{
    public partial class MainWindow : Window, IView
    {

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
