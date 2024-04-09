using HeroesOfCleanAndCode.Model.Helper;
using HeroesOfCleanAndCode.Interfaces;

namespace HeroesOfCleanAndCode.Model.Structures
{
    public class Structure : IStructure
    {
        public int maxHitPoints { get; protected set; }
        public int currentHitPoints { get; protected set; }
        public int shieldPoints { get; protected set; }
        public Position position { get; protected set; }
        public int moneyIncome { get; protected set; }
        public int scienceIncome { get; protected set; }
        public bool isDestroyed { get; protected set; }


        protected Structure(Position position)
        {
            this.position = position;
            isDestroyed = false;
        }
        ~Structure() { }

        public void TakeDamage(int damage)
        {
            currentHitPoints -= damage / shieldPoints;
            if (currentHitPoints <= 0) 
            {
                isDestroyed = true;
                currentHitPoints = 0;
            }
        }

        public void HealDamage(int points)
        {
            if (isDestroyed == false)
            {
                currentHitPoints += points;
                if (currentHitPoints > maxHitPoints)
                    currentHitPoints = maxHitPoints;
            }
        }
    }
}
