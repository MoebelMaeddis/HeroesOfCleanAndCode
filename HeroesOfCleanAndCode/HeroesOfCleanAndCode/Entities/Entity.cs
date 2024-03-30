﻿namespace HeroesOfCleanAndCode
{
    public class Entity : IEntity
    {
        public int maxHitPoints { get; protected set; }
        public int currentHitPoints { get; protected set; }
        public int shieldPoints { get; protected set; }
        public int damage { get; protected set; }
        public Position position { get; protected set; }
        public EntityLevel level { get; protected set; }
        public int cost { get; protected set; }
        public bool isDead { get; protected set; }

        public byte mobility { get; protected set; }
        public byte radius { get; protected set; }


        protected Entity(Position position)
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
            // Refactoring (?) after Test because of possible Divide by 0
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
            currentHitPoints = currentHitPoints + amount;
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
