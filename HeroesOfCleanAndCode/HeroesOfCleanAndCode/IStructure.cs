namespace HeroesOfCleanAndCode
{
    interface IStructure
    {
        int maxHitPoints { get; }
        int currentHitPoints { get; }
        int shieldPoints { get; }
        Position position { get; }
        int moneyIncome { get; }
        int scienceIncome { get; }
        bool isDestroyed { get; }


        void TakeDamage(int damage);
        void HealDamage(int points);
    }
}
