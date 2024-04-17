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
using HeroesOfCleanAndCode.Model.Core;
using MapSize = HeroesOfCleanAndCode.Model.Enums.MapSize;
using MapRelation = HeroesOfCleanAndCode.Model.Enums.MapRelation;

namespace xUnit.Tests
{
    public class MapTests
    {
        public MapTests() { }

        [Fact]
        public void CreateMap_CreatesMapWithCorrectSize()
        {
            // Arrange
            var mapSize = MapSize.Small;
            var mapRelation = MapRelation.Double;

            // Act
            var map = new Map(mapSize, mapRelation);

            // Assert
            map.terrainMap.GetLength(0).Should().Be((int)mapSize * (int)mapRelation);
            map.terrainMap.GetLength(1).Should().Be((int)mapSize);
        }

    }
}