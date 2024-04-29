using System.Windows;
using HeroesOfCleanAndCode.View.Main;
using HeroesOfCleanAndCode.Interfaces;

namespace HeroesOfCleanAndCode
{
    public partial class MainWindow : Window, IView
    {

        public MainWindow()
        {
            WindowState = WindowState.Maximized;
            Title = "Heroes of Clean and Code";

            //Globals.Instance;

            InitLayout();
        }

        public void InitLayout()
        {
            Content = new MainView();
        }
    }
}
