﻿using HeroesOfCleanAndCode.Model.Helper;
using HeroesOfCleanAndCode.Model.Enums;

namespace HeroesOfCleanAndCode.Interfaces
{
    interface IEntity
    {
        int maxHitPoints { get; }
        int currentHitPoints { get; }
        int shieldPoints { get; }
        int damage { get; }
        Position position { get; }
        EntityLevel level { get; }
        int cost { get; }
        bool isDead { get; }

        byte mobility { get; }
        byte range { get; }


        void Move(Direction direction);
        void TakeDamage(int amount);
        void HealDamage();
        void LevelUp();
    }
}
