#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Xml.Serialization;

namespace CpcLauncher.Dto
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Game
    {
        [XmlElement("path")]
        public string Path { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("thumbnail", IsNullable = true)]
        public string Thumbnail { get; set; }

        [XmlElement("image", IsNullable = true)]
        public string Image { get; set; }
        [XmlElement("marquee", IsNullable = true)]
        public string Marquee { get; set; }
        [XmlElement("video", IsNullable = true)]
        public string Video { get; set; }

        [XmlElement("rating", IsNullable = true)]
        public Rating? Rating { get; set; }

        [XmlElement("desc", IsNullable = true)]
        public string? Description { get; set; }

        [XmlElement("releasedate")]
        public string Releasedate { get; set; }

        [XmlElement("developer")]
        public string Developer { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("genre")]
        public string Genre { get; set; }

        [XmlElement("players")]
        public string Players { get; set; }

        [XmlIgnore()]
        [XmlElement("ratingSpecified")]
        public bool RatingSpecified { get; set; }

        [XmlElement("hash")]
        public string Hash { get; set; }

        [XmlElement("adult")]
        public bool Adult { get; set; }

        [XmlIgnore()]
        [XmlElement("adultSpecified")]
        public bool AdultSpecified { get; set; }

        [XmlElement("genreid")]
        public ushort Genreid { get; set; }

        [XmlIgnore()]
        [XmlElement("genreidSpecified")]
        public bool GenreidSpecified { get; set; }

        [XmlAttribute("id")]
        public uint Id { get; set; }

        [XmlAttribute("source")]
        public string Source { get; set; }
    }
}