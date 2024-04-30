using System.Windows.Controls;
using HeroesOfCleanAndCode.Controller.Main;
using HeroesOfCleanAndCode.View.Info;
using HeroesOfCleanAndCode.View.Map;
using HeroesOfCleanAndCode.Interfaces;


namespace HeroesOfCleanAndCode.View.Main
{
    public class MainView : StackPanel, IView
    {
        public MainController Controller { get; private set; }

        public MainView()
        {
            Controller = new MainController(this);

            InitLayout();
        }

        public void InitLayout()
        {
            Orientation = Orientation.Vertical;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;

            Children.Add(new MapView());
            Children.Add(new InfoView());
        }

        public void Update() { }
    }
}
