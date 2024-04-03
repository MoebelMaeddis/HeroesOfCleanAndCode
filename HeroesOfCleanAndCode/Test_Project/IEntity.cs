﻿namespace HeroesOfCleanAndCode
{
    interface IEntity : Heal
    {
        int maxHitPoints { get; }
        int currentHitPoints { get; }
        int shieldPoints { get; }
        int damage { get; }
        Position position { get; }
        int cost { get; }
        bool isDead { get; }

        byte mobility { get; }
        byte radius { get; }


        void Move(Direction direction);
        void TakeDamage(int amount);
        void HealDamage(int amount);
        void LevelUp();
    }
}
