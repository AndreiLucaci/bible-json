using System.Collections.Generic;
using BibleJsonFormatter.Engine.Contracts.BibleContracts;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Engine.Models
{
    public class Book: IBook
    {
        public int? Number { get; set; }

        public string Title { get; internal set; }

        public string SubTitle { get; internal set; }

        public IList<IChapter> Chapters => Collection;

        [JsonIgnore]
        public IList<IChapter> Collection { get; internal set; } = new List<IChapter>();
    }
}
