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

namespace xUnit.Tests.Entities
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
                entity.currentHitPoints.Should().Be(initialHitPoints - (damageAmount / entity.shieldPoints));
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
    }
}

