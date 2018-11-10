using System.Collections.Generic;
using BibleJsonFormatter.Models.Contracts;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Models
{
    public class Book: IBook
    {
        public int? Number { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public IList<IChapter> Chapters => Collection;

        [JsonIgnore]
        public IList<IChapter> Collection { get; set; } = new List<IChapter>();
    }
}
