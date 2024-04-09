using System.Windows.Controls;
using HeroesOfCleanAndCode.Controller.Info;
using static HeroesOfCleanAndCode.Controller.Info.InfoController;
using HeroesOfCleanAndCode.Interfaces;

namespace HeroesOfCleanAndCode.View.Info
{
    public class InfoView : Grid, IView
    {
        public InfoController Controller { get; private set; }

        public InfoView()
        {
            Controller = new InfoController(this);

            InitLayout();
        }

        public void InitLayout()
        {
            InfoButton(ButtonOption.NextEntity, "Next Entity");
            InfoButton(ButtonOption.NextAction, "Next Action");

        }

        public void InfoButton(ButtonOption option, string text)
        {
            Button button = new Button();

            button.Content = text;
            button.Click += new System.Windows.RoutedEventHandler((obj, e) =>
            {
                Controller.InfoButtonClicked(option);
            });
            button.Margin = new System.Windows.Thickness(10);

            Children.Add(button);
        }

    }
}
