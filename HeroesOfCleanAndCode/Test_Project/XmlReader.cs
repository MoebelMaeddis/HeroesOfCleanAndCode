using System;
using System.Linq;
using System.Text;
using System.Xml;

namespace HeroesOfCleanAndCode
{
    public class XmlReader
    {
        private string url { get; }
        public XmlDocument xmlDocument { get; }

        /*public XmlReader(string url)
        {
            this.url = url;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(this.url);
        }*/

        public interface IXmlLoader
        {
            string LoadXmlFromUrl(string url);
        }

        public XmlReader(string url, IXmlLoader xmlLoader)
        {
            this.url = url;
            xmlDocument = new XmlDocument();
            string xmlContent = xmlLoader.LoadXmlFromUrl(url);
            xmlDocument.LoadXml(xmlContent);
        }
        

    }
}
