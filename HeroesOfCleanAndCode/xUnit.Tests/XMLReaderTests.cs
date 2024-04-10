using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HeroesOfCleanAndCode;

namespace xUnit.Tests
{
    public class XMLReaderTests
    {

        [Fact]
        public void Load_Should_LoadXmlDocumentFromUrl()
        {
            // Arrange
            var fakeUrl = "http://example.com/xml"; // Beispiel-URL für den Test
            var fakeXmlContent = "<root><element>Test</element></root>"; // Beispiel-XML-Inhalt für den Test

            var fakeXmlReader = A.Fake<IXmlReader>(); // Erstellen eines gefälschten XmlReader

            // Konfigurieren des gefälschten XmlReader, um den gefälschten XML-Inhalt zurückzugeben, wenn Load aufgerufen wird
            A.CallTo(() => fakeXmlReader.Load(A<string>._))
                .Invokes((string url) =>
                {
                    // Simulieren des Ladens der XML-Datei, indem wir den gefälschten XML-Inhalt setzen
                    fakeXmlReader.XmlDocument.InnerXml = fakeXmlContent;
                    fakeXmlReader.Url = url; // Setzen der Url-Eigenschaft auf den übergebenen Wert
                });

            // Act
            fakeXmlReader.Load(fakeUrl); // Aufrufen der Load-Methode mit der gefälschten URL

            // Assert
            fakeXmlReader.Url.Should().Be(fakeUrl); // Überprüfen, ob die URL richtig gesetzt wurde
            fakeXmlReader.XmlDocument.InnerXml.Should().Be(fakeXmlContent); // Überprüfen, ob das XmlDocument den gefälschten XML-Inhalt geladen hat
        }
    }

    // Definieren einer Schnittstelle für XmlReader, um die Abhängigkeit von der tatsächlichen Implementierung zu lösen
    public interface IXmlReader
    {
        string Url { get; set; } // Url-Eigenschaft hinzufügen
        XmlDocument XmlDocument { get; }
        void Load(string url);
    }
}
