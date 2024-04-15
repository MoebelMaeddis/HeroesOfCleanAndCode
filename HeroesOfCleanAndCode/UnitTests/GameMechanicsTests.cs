﻿using FluentAssertions;
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

namespace UnitTests
{
    public class TestableEntity : Entity // Erstellen einer abgeleiteten Klasse für Tests
    {
        public TestableEntity(Position position, int initialHitPoints, int initialShieldPoints, int intitialMaxHitPoints) : base(position)
        {
            currentHitPoints = initialHitPoints;
            shieldPoints = initialShieldPoints;
            maxHitPoints = intitialMaxHitPoints;
        }
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
            var entity = new TestableEntity(fakePosition, 100, 20, 100);
            int initialHitPoints = entity.currentHitPoints;
            int damageAmount = 20;

            // Act
            entity.TakeDamage(damageAmount);

            // Assert
            if (entity.shieldPoints != 0)
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
            var entity = new TestableEntity(fakePosition, 10, 0, 100);
            int damageAmount = 20;

            // Act
            entity.TakeDamage(damageAmount);

            // Assert
            entity.isDead.Should().BeTrue();
        }

        [Fact]
        public void HealDamage_Should_Increase_currentHits()
        {
            // Arrange
            var fakePosition = A.Fake<Position>();
            var entity = new TestableEntity(fakePosition, 60, 0, 100);
            int initialHitPoints = entity.currentHitPoints;
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
            var fakePosition = A.Fake<Position>();
            var entity = new TestableEntity(fakePosition, 100, 0, 100);
            int maxHitPoints = entity.maxHitPoints;
            int healAmount = 20;

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
