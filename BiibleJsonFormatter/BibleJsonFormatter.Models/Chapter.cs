using System.Collections.Generic;
using BibleJson.Models.Contracts;
using Newtonsoft.Json;

namespace BibleJson.Models
{
    public class Chapter: IChapter
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public int? Number { get; set; }
        
        public IList<IVerse> Verses
        {
            get => Collection;
            set => Collection = value;
        }

        [JsonIgnore]
        public IList<IVerse> Collection { get; set; } = new List<IVerse>();
    }
}
