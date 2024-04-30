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

        public void Update()
        {
            Controller.UpdateInfoView();
        }

        public void InitLayout()
        {
            Universal.GridDefinitions(this, Tuple.Create(10, 3));

            InfoButton(InfoNextButtonOption.Entity, new Position(1, 0));
            InfoButton(InfoNextButtonOption.Action, new Position(1, 1));

            InfoEntityLabel(InfoEntityLabelOptions.Name, new Position(5, 0));
            InfoEntityLabel(InfoEntityLabelOptions.Health, new Position(6, 0));
            InfoEntityLabel(InfoEntityLabelOptions.Damage, new Position(6, 1));
            InfoEntityLabel(InfoEntityLabelOptions.Armor, new Position(7, 0));
            InfoEntityLabel(InfoEntityLabelOptions.Speed, new Position(8, 0));
            InfoEntityLabel(InfoEntityLabelOptions.Range, new Position(8, 1));

            InfoGameLabel(InfoGameLabelOptions.Round, new Position(3, 0));
            InfoGameLabel(InfoGameLabelOptions.Player, new Position(3, 1));
            InfoGameLabel(InfoGameLabelOptions.Entity, new Position(3, 2));
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

        public void InfoEntityLabel(InfoEntityLabelOptions labelOption, Position position)
        {
            Label label = new Label();
            Styles.SetInfoLabelStyle(label);

            label.Content = "Entity " + labelOption.ToString();
            
            Grid.SetColumn(label, position.x);
            Grid.SetRow(label, position.y);

            Labels.Add(labelOption.ToString(), label);
            Children.Add(label);
        }

        public void InfoGameLabel(InfoGameLabelOptions labelOption, Position position)
        {
            Label label = new Label();
            Styles.SetInfoLabelStyle(label);

            label.Content = labelOption.ToString();

            Grid.SetColumn(label, position.x);
            Grid.SetRow(label, position.y);

            Labels.Add(labelOption.ToString(), label);
            Children.Add(label);
        }

    }
}
