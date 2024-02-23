using System;
using System.Xml.Serialization;

namespace Emu.Common.Dto
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class Folder
    {
        [XmlElement("path")]
        public string? Path { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("desc")]
        public string? Description { get; set; }

        [XmlElement("image")]
        public string? Image { get; set; }

        [XmlAttribute("id")]
        public byte? Id { get; set; }

        [XmlAttribute("source")]
        public string? Source { get; set; }
    }
}