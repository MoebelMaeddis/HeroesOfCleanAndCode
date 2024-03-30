using FluentAssertions;
using FluentAssertions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FakeItEasy;
using System.Reflection.Metadata; //Mocking Framework
using HeroesOfCleanAndCode;

namespace xUnit.Tests
{
    public class EntityTests
    {
        [Fact]
        public void TakeDamage_Should_Reduce_CurrentHitPoints()
        {
            // Arrange
            var fakePosition = A.Fake<Position>(); // Erstellen eines gefälschten Position-Objekts mit FakeItEasy
            var entity = new Entity(fakePosition);
            int initialHitPoints = entity.currentHitPoints;
            int damageAmount = 20;

            // Act
            entity.TakeDamage(damageAmount);

            // Assert
            if (entity.shieldPoints > 0)
            {
                entity.currentHitPoints.Should().Be(initialHitPoints - damageAmount / entity.shieldPoints);
            }
            else
            {
                entity.currentHitPoints.Should().Be(initialHitPoints - damageAmount);
            }
        }

        [Fact]
        public void TakeDamage_Should_Set_IsDead_When_CurrentHitPoints_Less_Or_Equal_To_Zero()
        {
            // Arrange
            var fakePosition = A.Fake<Position>(); // Erstellen eines gefälschten Position-Objekts mit FakeItEasy
            var entity = new Entity(fakePosition);
            int initialHitPoints = entity.currentHitPoints;

            // Act
            entity.TakeDamage(initialHitPoints * entity.shieldPoints);

            // Assert
            entity.isDead.Should().BeTrue();
        }

        [Fact]
        public void HealDamage_Should_Increase_CurrentHitPoints()
        {
            // Arrange
            var fakePosition = A.Fake<Position>(); // Erstellen eines gefälschten Position-Objekts mit FakeItEasy
            var entity = new Entity(fakePosition)
            {
                maxHitPoints = 100,
                currentHitPoints = 50 // Startwert der aktuellen Trefferpunkte
            };
            int healAmount = 20;

            // Act
            entity.HealDamage(healAmount);

            // Assert            
            entity.currentHitPoints.Should().Be(initialHitPoints + healAmount);
        }

        [Fact]
        public void HealDamage_Should_Set_CurrentHitPoints_To_MaxHitPoints_When_CurrentHitPoints_Is_Above_MaxHitPoints()
        {
            // Arrange
            var fakePosition = A.Fake<Position>(); // Erstellen eines gefälschten Position-Objekts mit FakeItEasy
            var entity = new Entity(fakePosition);
            int initialHitPoints = entity.currentHitPoints;
            int maxHitPoints = entity.maxHitPoints;
            int healAmount = maxHitPoints - initialHitPoints + 1;

            // Act
            entity.HealDamage(healAmount);

            // Assert
            entity.currentHitPoints.Should().Be(maxHitPoints);
        }

        [Fact]
        public void LevelUp_Should_Increase_Level()
        {
            //
        }
    }
   
}

