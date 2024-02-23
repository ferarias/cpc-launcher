using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CpcLauncher.Dto
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "gameList", Namespace = "", IsNullable = false)]
    public class GameList
    {
        [XmlElement("game", IsNullable = false)]
        public List<Game> Games { get; set; } = [];
    }
}
