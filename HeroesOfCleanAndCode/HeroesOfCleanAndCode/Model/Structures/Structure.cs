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
            currentHitPoints = DamageableSystem.TakeDamage(damage, currentHitPoints, shieldPoints);

            isDestroyed = currentHitPoints == 0 ? true : false;
        }

        public void HealDamage()
        {
            if (!isDestroyed) currentHitPoints = DamageableSystem.HealDamage(currentHitPoints, maxHitPoints);
        }
    }
}
