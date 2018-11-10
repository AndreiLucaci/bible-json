using System.Collections.Generic;
using BibleJsonFormatter.Engine.Contracts.BibleContracts;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Engine.Models
{
    public class Bible : IBible
    {
        public string Title { get; internal set; } = "Bibla";

        public IList<IBook> Books => Collection;

        [JsonIgnore]
        public IList<IBook> Collection { get; internal set; } = new List<IBook>();
    }
}
