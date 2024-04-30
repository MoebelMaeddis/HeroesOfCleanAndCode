using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Model.Entities;
using HeroesOfCleanAndCode.Model.Helper;
using HeroesOfCleanAndCode.View.Info;
using HeroesOfCleanAndCode.Interfaces;

namespace HeroesOfCleanAndCode.Controller.Info
{
    public class InfoController : IController
    {
        public enum InfoNextButtonOption
        {
            Entity,
            Action,
        }

        public enum InfoGameLabelOptions
        {
            Round,
            Player,
            Entity,
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

        private readonly EventAggregator _eventAggregator;

        public InfoController(InfoView view)
        {
            _eventAggregator = Globals.Instance().eventAggregator;
            _eventAggregator.UpdateCalled += Update;
            View = view;
        }

        public void Update(object sender, string updateCallData)
        {
            UpdateInfoView();
        }

        public void CallUpdate(string callData)
        {
            _eventAggregator.UpdateEvent(callData);
        }

        public void InfoButtonClicked(InfoNextButtonOption option)
        {
            Globals globals = Globals.Instance();
            GameState gameState = globals.gameState;

            if (option == InfoNextButtonOption.Entity) gameState.NextEntity();
            else if (option == InfoNextButtonOption.Action) gameState.NextAction();

            CallUpdate(null);
        }

        public void UpdateInfoView()
        {

            Globals globals = Globals.Instance();
            GameState gameState = globals.gameState;
            Game game  = globals.game;

            Player activePlayer = game.players[gameState.activePlayerIndex];
            Entity activeEntity = activePlayer.entities[gameState.activeEntityIndex];

            UpdateEntityLabel(InfoEntityLabelOptions.Name, activeEntity.GetType().Name);
            UpdateEntityLabel(InfoEntityLabelOptions.Health, activeEntity.currentHitPoints.ToString());
            UpdateEntityLabel(InfoEntityLabelOptions.Damage, activeEntity.damage.ToString());
            UpdateEntityLabel(InfoEntityLabelOptions.Armor, activeEntity.shieldPoints.ToString());
            UpdateEntityLabel(InfoEntityLabelOptions.Speed, activeEntity.mobility.ToString());
            UpdateEntityLabel(InfoEntityLabelOptions.Range, activeEntity.range.ToString());

            UpdateGameLabel(InfoGameLabelOptions.Round, gameState.activeRoundIndex.ToString());
            UpdateGameLabel(InfoGameLabelOptions.Player, gameState.activePlayerIndex.ToString());
            UpdateGameLabel(InfoGameLabelOptions.Entity, gameState.activeEntityIndex.ToString());
        }

        public void UpdateEntityLabel(InfoEntityLabelOptions option, string value)
        {
            View.Labels[option.ToString()].Content = "Entity " + option.ToString() + ": " + value;
        }
        
        public void UpdateGameLabel(InfoGameLabelOptions option, string value)
        {
            View.Labels[option.ToString()].Content = option.ToString() + ": " + value;
        }

    }
}
