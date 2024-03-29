﻿namespace HeroesOfCleanAndCode
{
    public class Entity : IEntity
    {
        public enum EntityLevel
        {
            Rookie = 1,
            Intermediate = 2,
            Officer = 3,
            General = 4,
            Major = 5,
        }
        public int maxHitPoints { get; protected set; }
        public int currentHitPoints { get; protected set; }
        public int shieldPoints { get; protected set; }
        public int damageTaken;
        public int damage { get; protected set; }
        public Position position { get; protected set; }
        public EntityLevel level { get; protected set; }
        public int cost { get; protected set; }
        public bool isDead { get; protected set; }

        public byte mobility { get; protected set; }
        public byte radius { get; protected set; }


        public Entity(Position position)
        {
            this.position = position;
            level = EntityLevel.Rookie;
            isDead = false;
        }
        ~Entity() { }

        public void Move(Direction direction)
        {
            position.Translate(direction);
        }

        public void TakeDamage(int amount)
        {
            // Refactoring after Test because of possible Divide by 0
            if (shieldPoints > 0)
            {
                currentHitPoints -= amount / shieldPoints;
            }
            else
            {
                currentHitPoints -= amount;
            }
            //
            if (currentHitPoints <= 0) isDead = true;
        }

        public void HealDamage(int amount)
        {
            currentHitPoints += amount;
            if (currentHitPoints > maxHitPoints) currentHitPoints = maxHitPoints;
        }

        public void LevelUp()
        {
            if (level != EntityLevel.Major)
            {
                level = level.Next();

                float multiplier = 1 + (int)level.GetTypeCode() * 2 / 10;

                maxHitPoints = (int)(maxHitPoints * multiplier);
                currentHitPoints = (int)(currentHitPoints * multiplier);
                shieldPoints = (int)(shieldPoints * multiplier);
                damage = (int)(damage * multiplier);
            }
        }
    }
}
