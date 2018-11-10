using System.Collections.Generic;
using BibleJson.Models.Contracts;
using Newtonsoft.Json;

namespace BibleJson.Models
{
    public class Book: IBook
    {
        public int? Number { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public IList<IChapter> Chapters
        {
            get => Collection;
            set => Collection = value;
        }

        [JsonIgnore]
        public IList<IChapter> Collection { get; set; } = new List<IChapter>();
    }
}
