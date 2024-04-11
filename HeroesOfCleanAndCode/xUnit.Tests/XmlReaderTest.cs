using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesOfCleanAndCode;
using XmlReader = HeroesOfCleanAndCode.XmlReader;

namespace xUnit.Tests
{
    public class XmlReaderTest
    {
        [Fact]
        public void XmlReader_Loads_Url_Content()
        {
            // Arrange
            string fakeUrl = "http://fake.url";
            string fakeXmlContent = "<root><element>test</element></root>";

            var fakeXmlLoader = A.Fake<XmlReader.IXmlLoader>();
            A.CallTo(() => fakeXmlLoader.LoadXmlFromUrl(A<string>.Ignored))
                .Returns(fakeXmlContent);

            // Act
            var xmlReader = new XmlReader(fakeUrl, fakeXmlLoader);

            // Assert
            Assert.Equal(fakeXmlContent, xmlReader.xmlDocument.OuterXml);
            
            xmlReader.xmlDocument.OuterXml.Should().BeEquivalentTo(fakeXmlContent);
        }

    }
}
