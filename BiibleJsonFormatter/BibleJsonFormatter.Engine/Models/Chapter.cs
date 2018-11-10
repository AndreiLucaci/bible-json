using System.Collections.Generic;
using BibleJsonFormatter.Engine.Contracts.BibleContracts;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Engine.Models
{
    public class Chapter: IChapter
    {
        public string Title { get; internal set; }

        public string SubTitle { get; internal set; }

        public int? Number { get; set; }

        public IList<IVerse> Verses => Collection;

        [JsonIgnore]
        public IList<IVerse> Collection { get; internal set; } = new List<IVerse>();
    }
}
