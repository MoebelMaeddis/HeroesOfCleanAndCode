using System;
using System.Linq;
using System.Text;
using System.Xml;

namespace HeroesOfCleanAndCode.Assets.Config
{
    internal class XmlReader
    {
        private string url { get; }
        private XmlDocument xmlDocument { get; }

        public XmlReader(string url)
        {
            this.url = url;
            xmlDocument = new XmlDocument();
            xmlDocument.Load(this.url);
        }
    }
}
