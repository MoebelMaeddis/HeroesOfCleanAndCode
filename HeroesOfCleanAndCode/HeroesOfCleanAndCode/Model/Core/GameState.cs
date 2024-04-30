using HeroesOfCleanAndCode.Model.Entities;
using HeroesOfCleanAndCode.Model.Enums;
using HeroesOfCleanAndCode.Model.Helper;
using HeroesOfCleanAndCode.Model.Structures;

namespace HeroesOfCleanAndCode.Model.Core
{
    public class GameState
    {
        public int activeRoundIndex { get; set; }
        public int activePlayerIndex {  get; set; }
        public int activeEntityIndex { get; set; }
        public Actions activeAction { get; set; }

        public GameState()
        {
            activeAction = Actions.Move;
            activeEntityIndex = 0;
            activePlayerIndex = 0;
            activeRoundIndex = 0;
        }

        public void NextAction()
        {
            if (activeAction == Actions.Attack) NextEntity();
            else activeAction.Next();
        }

        public void NextEntity()
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;

            activeAction = Actions.Move;

            activeEntityIndex++;
            if (activeEntityIndex >= game.players[activePlayerIndex].entities.Count)
            {
                activeEntityIndex = 0;
                NextPlayer();
            }
        }

        public void NextPlayer()
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;

            activePlayerIndex++;
            if(activePlayerIndex >= game.players.Length)
            {
                activePlayerIndex = 0;
                NextRound();
            }

        }

        public void NextRound()
        {
            Globals globals = Globals.Instance();
            Game game = globals.game;

            activeRoundIndex++;
            foreach(Player p in game.players)
            {
                foreach(Structure s in p.structures)
                {
                    p.moneyBalance += s.moneyIncome;
                    p.scienceBalance += s.scienceIncome;
                }

                foreach (Entity e in p.entities)
                {
                    p.moneyBalance -= e.cost;
                }
            }
        }
    }
}
