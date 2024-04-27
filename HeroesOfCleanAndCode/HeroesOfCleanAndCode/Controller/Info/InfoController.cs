using HeroesOfCleanAndCode.View.Info;

namespace HeroesOfCleanAndCode.Controller.Info
{
    public class InfoController
    {
        public enum InfoNextButtonOption
        {
            Entity,
            Action,
        }

        public enum InfoEntityLabelOptions
        {
            Name,
            Health,
            Damage,
            Armor,
            Speed,
            Range,
        }

        public InfoView View { get; private set; }

        public InfoController(InfoView view)
        {
            View = view;
        }
        public void InfoButtonClicked(InfoNextButtonOption option)
        {
            switch (option)
            {
                case InfoNextButtonOption.Entity:
                    break;
                case InfoNextButtonOption.Action:
                    break;
            }
        }

    }
}
