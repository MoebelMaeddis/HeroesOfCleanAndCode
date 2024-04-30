using ABI.System.Collections.Generic;
using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Model.Entities;
using HeroesOfCleanAndCode.View.Info;
using System.Reflection.Emit;

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
            Globals globals = Globals.Instance();
            GameState gameState = globals.gameState;

            switch (option)
            {
                case InfoNextButtonOption.Entity:
                    gameState.NextEntity();
                    break;

                case InfoNextButtonOption.Action:
                    gameState.NextAction();
                    break;
            }

            UpdateInfoView();
        }

        public void UpdateInfoView()
        {

            Globals globals = Globals.Instance();
            GameState gameState = globals.gameState;
            Game game  = globals.game;

            Player activePlayer = game.players[gameState.activePlayerIndex]
        }

    }
}
