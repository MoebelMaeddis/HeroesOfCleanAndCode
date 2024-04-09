using HeroesOfCleanAndCode.View.Info;
using static HeroesOfCleanAndCode.Controller.Main.MainController;

namespace HeroesOfCleanAndCode.Controller.Info
{
    public class InfoController
    {
        public enum ButtonOption
        {
            NextEntity,
            NextAction,
        }

        public InfoView View { get; private set; }

        public InfoController(InfoView view)
        {
            View = view;
        }
        public void InfoButtonClicked(ButtonOption option)
        {
            switch (option)
            {
                case ButtonOption.NextEntity:
                    break;
                case ButtonOption.NextAction:
                    break;
            }
        }

    }
}
