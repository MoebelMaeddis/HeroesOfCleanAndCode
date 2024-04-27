using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.View.Main;

namespace HeroesOfCleanAndCode.Controller.Main
{
    
    public class MainController
    {
        public MainView View { get; private set; }

        public MainController(MainView view)
        {
            View = view;
        }

    }
}
