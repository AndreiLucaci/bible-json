using System.Collections.Generic;
using BibleJson.Models.Contracts;
using Newtonsoft.Json;

namespace BibleJson.Models
{
    public class Bible : IBible
    {
        public string Title { get; set; } = "Bibla";

        public IList<IBook> Books
        {
            get => Collection;
            set => Collection = value;
        } 

        [JsonIgnore]
        public IList<IBook> Collection { get; set; } = new List<IBook>();
    }
}
