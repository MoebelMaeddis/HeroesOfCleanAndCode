using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfCleanAndCode
{
    public class Heal
    {
        public void HealDamage(int amount, int currentHitPoints, int maxHitPoints)
        {
            currentHitPoints = currentHitPoints + amount;
            if (currentHitPoints > maxHitPoints)
            {
                currentHitPoints = maxHitPoints;
            }
        }
    }
}
