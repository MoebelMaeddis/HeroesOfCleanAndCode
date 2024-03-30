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
using static HeroesOfCleanAndCode.Position;

namespace xUnit.Tests
{
    public class PositionTests
    {

        [Fact]
        public void Translate_Should_Return_Correct_New_Position()
        {
            
            var position = new Position();
        }
    }
}

