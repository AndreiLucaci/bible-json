using System.Collections.Generic;
using BibleJsonFormatter.Models.Contracts;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Models
{
    public class Chapter: IChapter
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public int? Number { get; set; }

        public IList<IVerse> Verses => Collection;

        [JsonIgnore]
        public IList<IVerse> Collection { get; set; } = new List<IVerse>();
    }
}
