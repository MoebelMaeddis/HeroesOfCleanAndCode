namespace HeroesOfCleanAndCode.Model.Helper
{
    public static class DamageableSystem
    {
        public static int TakeDamage(int damage, int currentHitPoints, int shieldPoints)
        {
            shieldPoints = shieldPoints > 0 ? 1 : shieldPoints;

            int newHitPoints = currentHitPoints - (int)(damage / shieldPoints);

            return newHitPoints < 0 ? 0 : newHitPoints;
        }

        public static int HealDamage(int currentHitPoints, int maxHitPoints)
        {
            int newHitPoints = currentHitPoints + (int)(maxHitPoints * 0.1);

            return newHitPoints > maxHitPoints ? maxHitPoints : newHitPoints;
        }
    }
}
