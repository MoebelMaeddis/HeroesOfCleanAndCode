using HeroesOfCleanAndCode.Model.Core;
using HeroesOfCleanAndCode.Model.Helper;
using HeroesOfCleanAndCode.View.Main;
using System.Windows.Input;

namespace HeroesOfCleanAndCode.Controller.Main
{
    
    public class MainController
    {
        public MainView View { get; private set; }

        public MainController(MainView view)
        {
            View = view;
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;
            GameState gameState = globals.gameState;

            Direction direction =
                e.Key == Key.Q ? Direction.UpLeft :
                e.Key == Key.W ? Direction.Up :
                e.Key == Key.E ? Direction.UpRight :
                e.Key == Key.A ? Direction.Left :
                e.Key == Key.D ? Direction.Right :
                e.Key == Key.Y ? Direction.DownLeft :
                e.Key == Key.X ? Direction.Down :
                e.Key == Key.C ? Direction.DownRight :
                Direction.None;

            game.players[gameState.activePlayerIndex].entities[gameState.activeEntityIndex].Move(direction);
        }
    }
}
