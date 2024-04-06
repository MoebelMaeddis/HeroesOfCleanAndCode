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
using static HeroesOfCleanAndCode.Position;
using MapSize = HeroesOfCleanAndCode.MapSize;
using MapRelation = HeroesOfCleanAndCode.MapRelation;

namespace xUnit.Tests
{
    /*public enum TestMapSize
    {
        Tiny = 20,
        Small = 30,
        Medium = 50,
        Large = 75,
        Huge = 100,
    }

    public enum TestMapRelation
    {
        Quadratic = 1,
        Double = 2,
    }

    public class TestableMap: Map // Erstellen einer abgeleiteten Klasse für Tests
    {
        public TestableMap(MapSize mapSize, MapRelation mapRelation) : base(mapSize, mapRelation)
        {
            this.mapSize = mapSize;
            this.mapRelation = mapRelation;
        }
    }

    public class MapTests 
    {
        public MapTests() { }

        [Fact]
        public void CreateMap_CreatesMapWithCorrectSize()
        {
            // Arrange
            var mapSize = TestMapSize.Small;
            var mapRelation = TestMapRelation.Double;

            // Act
            var map = new TestableMap(mapSize, mapRelation);

            // Assert
            map.terrainMap.GetLength(0).Should().Be((int)mapSize * (int)mapRelation);
            map.terrainMap.GetLength(1).Should().Be((int)mapSize);
        }

    }*/
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
