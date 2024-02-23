using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CpcLauncher.Dto
{
    public class Rating : IXmlSerializable
    {
        private decimal? _rating;

        public XmlSchema? GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            try
            {
                _rating = reader.ReadElementContentAsDecimal();
            }
            catch(FormatException)
            {
                _rating = null;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteValue(_rating!);
        }
    }
}