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
using System.Reflection.Metadata; 
using HeroesOfCleanAndCode;
using System.Runtime.InteropServices;
using HeroesOfCleanAndCode.Model.Helper;

namespace xUnit.Tests
{
    public class DirectionTests
    {
        public DirectionTests() { }

        [Fact]
        public void Directions_Should_Have_Correct_Offsets()
        {
            // Arrange & Act
            var inDirection = Direction.In;
            var upDirection = Direction.Up;
            var leftDirection = Direction.Left;
            var downDirection = Direction.Down;
            var rightDirection = Direction.Right;
            var upLeftDirection = Direction.UpLeft;
            var upRightDirection = Direction.UpRight;
            var downLeftDirection = Direction.DownLeft;
            var downRightDirection = Direction.DownRight;

            // Assert
            inDirection.xOffset.Should().Be(0);
            inDirection.yOffset.Should().Be(0);

            upDirection.xOffset.Should().Be(-1);
            upDirection.yOffset.Should().Be(0);

            leftDirection.xOffset.Should().Be(0);
            leftDirection.yOffset.Should().Be(-1);

            downDirection.xOffset.Should().Be(1);
            downDirection.yOffset.Should().Be(0);

            rightDirection.xOffset.Should().Be(0);
            rightDirection.yOffset.Should().Be(1);

            upLeftDirection.xOffset.Should().Be(-1);
            upLeftDirection.yOffset.Should().Be(-1);

            upRightDirection.xOffset.Should().Be(-1);
            upRightDirection.yOffset.Should().Be(1);

            downLeftDirection.xOffset.Should().Be(1);
            downLeftDirection.yOffset.Should().Be(-1);

            downRightDirection.xOffset.Should().Be(1);
            downRightDirection.yOffset.Should().Be(1);
        }

        [Fact]
        public void Directions_Should_Have_Correct_Equality()
        {
            // Arrange
            var direction1 = Direction.Up;
            var direction2 = Direction.Left;
            var direction3 = Direction.Up;

            // Act & Assert
            direction1.Should().NotBe(direction2);
            direction1.Should().Be(direction3);
        }

        [Fact]
        public void Directions_Should_Have_Correct_Equals_Method()
        {
            // Arrange
            var direction1 = Direction.Up;
            var direction2 = Direction.Left;
            var direction3 = Direction.Up;

            // Act & Assert
            direction1.Equals(direction2).Should().BeFalse();
            direction1.Equals(direction3).Should().BeTrue();
        }

        [Fact]
        public void Directions_Should_Have_Unique_Hash_Codes()
        {
            // Arrange
            var direction1 = Direction.Up;
            var direction2 = Direction.Left;
            var direction3 = Direction.Up;

            // Act & Assert
            direction1.GetHashCode().Should().NotBe(direction2.GetHashCode());
            direction1.GetHashCode().Should().Be(direction3.GetHashCode());
        }
    }
}