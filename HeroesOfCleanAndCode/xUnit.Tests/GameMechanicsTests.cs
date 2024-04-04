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
using System.Runtime.InteropServices;

namespace xUnit.Tests
{
    public class TestableEntity : Entity // Erstellen einer abgeleiteten Klasse für Tests
    {
        public TestableEntity(Position position) : base(position)
        {
        }

        // Hier können Sie zusätzliche Methoden hinzufügen, um den Zugriff auf die geschützten Elemente zu erleichtern, falls erforderlich.
    }

    public class EntityTests
    {
        public EntityTests() 
        {

        }

        [Fact]
        public void TakeDamage_Should_Reduce_CurrentHitPoints()
        {
            // Arrange
            var fakePosition = A.Fake<Position>(); // Erstellen eines gefälschten Position-Objekts mit FakeItEasy
            var entity = new TestableEntity(fakePosition);
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
            var entity = new TestableEntity(fakePosition);
            int initialHitPoints = entity.currentHitPoints;

            // Act
            entity.TakeDamage(initialHitPoints * entity.shieldPoints);

            // Assert
            entity.isDead.Should().BeTrue();
        }

        [Fact]
        public void HealDamage_Should_Increase_currentHits()
        {
            // Arrange
            var fakePosition = A.Fake<Position>();
            var entity = new TestableEntity(fakePosition);
            int initialHitPoints = entity.currentHits;
            int maxHitPoints = entity.maxHits;
            int healAmount = maxHitPoints - initialHitPoints;            


            // Mittels FakeItEasy Simulieren, dass die aktuellen Trefferpunkte zuerst auf einen bestimmten Wert gesetzt wurden
            //A.CallTo(() => entity.currentHitPoints).Returns(initialCurrentHitPoints);

            //A.CallTo(() => entity.maxHitPoints).Returns(MaximumHitPoints);

            // Act
            entity.HealDamage(healAmount);

            // Assert
            //entity.currentHitPoints.Should().Be(initialHitPoints + healAmount);
            entity.currentHits.Should().Be(initialHitPoints + healAmount);
            //A.CallTo(() => entity.currentHitPoints).MustHaveHappenedOnceExactly();
            //A.CallTo(() => entity.currentHitPoints).Where(args => args.GetArgument<int>(0) == 80).MustHaveHappenedOnceExactly();
        }
   

        [Fact]
        public void HealDamage_Should_Set_CurrentHitPoints_To_MaxHitPoints_When_CurrentHitPoints_Is_Above_MaxHitPoints()
        {
            // Arrange
            //var fakePosition = A.Fake<Position>(); // Erstellen eines gefälschten Position-Objekts mit FakeItEasy
            //var entity = new Entity(fakePosition);
            //int initialHitPoints = entity.currentHitPoints;
            //int maxHitPoints = entity.maxHitPoints;
            //int healAmount = maxHitPoints - initialHitPoints + 1;
            var fakePosition = A.Fake<Position>();
            var entity = new TestableEntity(fakePosition);
            int initialHitPoints = entity.currentHits;
            int maxHitPoints = entity.maxHits;
            int healAmount = maxHitPoints - initialHitPoints + 1;

            // Act
            entity.HealDamage(healAmount);

            // Assert
            entity.currentHits.Should().Be(maxHitPoints);
        }

        [Fact]
        public void LevelUp_Should_Increase_Level()
        {
            //
        }
    }
   
}

