using System.Collections.Generic;
using BibleJsonFormatter.Models.Contracts;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Models
{
    public class Bible : IBible
    {
        public string Title { get; set; } = "Bibla";

        public IList<IBook> Books => Collection;

        [JsonIgnore]
        public IList<IBook> Collection { get; set; } = new List<IBook>();
    }
}
