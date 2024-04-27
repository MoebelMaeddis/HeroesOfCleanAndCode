using static HeroesOfCleanAndCode.Controller.Info.InfoController;
using HeroesOfCleanAndCode.Controller.Info;
using HeroesOfCleanAndCode.Model.Helper;
using HeroesOfCleanAndCode.Interfaces;
using System.Collections.Generic;
using System.Windows.Controls;
using System;

namespace HeroesOfCleanAndCode.View.Info
{
    public class InfoView : Grid, IView
    {
        public InfoController Controller { get; private set; }
        public Dictionary<string, Label> Labels { get; private set; }

        public InfoView()
        {
            Controller = new InfoController(this);
            Labels = new Dictionary<string, Label>();

            InitLayout();
        }

        public void InitLayout()
        {
            Universal.GridDefinitions(this, Tuple.Create(8, 2));

            InfoButton(InfoNextButtonOption.Entity, new Position(1, 0));
            InfoButton(InfoNextButtonOption.Action, new Position(1, 1));

            InfoLabel(InfoEntityLabelOptions.Name, new Position(3, 0));
            InfoLabel(InfoEntityLabelOptions.Health, new Position(4, 0));
            InfoLabel(InfoEntityLabelOptions.Damage, new Position(4, 1));
            InfoLabel(InfoEntityLabelOptions.Armor, new Position(5, 0));
            InfoLabel(InfoEntityLabelOptions.Speed, new Position(6, 0));
            InfoLabel(InfoEntityLabelOptions.Range, new Position(6, 1));
        }

        public void InfoButton(InfoNextButtonOption option, Position position)
        {
            Button button = new Button();
            Styles.SetInfoButtonStyle(button);

            button.Content = "Next " + option.ToString();

            button.Click += new System.Windows.RoutedEventHandler((obj, e) =>
            {
                Controller.InfoButtonClicked(option);
            });

            Grid.SetColumn(button, position.x);
            Grid.SetRow(button, position.y);

            Children.Add(button);
        }

        public void InfoLabel(InfoEntityLabelOptions labelOption, Position position)
        {
            Label label = new Label();
            Styles.SetInfoLabelStyle(label);

            label.Content = "Entity " + labelOption.ToString();
            
            Grid.SetColumn(label, position.x);
            Grid.SetRow(label, position.y);

            Labels.Add(labelOption.ToString(), label);
            Children.Add(label);
        }

    }
}
