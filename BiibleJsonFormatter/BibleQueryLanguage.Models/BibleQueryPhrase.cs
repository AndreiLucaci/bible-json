using System.Collections.Generic;
using BibleQueryLanguage.Models.Contracts;

namespace BibleQueryLanguage.Models
{
    public class BibleQueryPhrase : IBibleQueryPhrase
    {
        public string OriginalText { get; set; }

        public IList<IBibleQueryToken> Collection { get; set; } = new List<IBibleQueryToken>();

        public IList<IBibleQueryToken> Tokens
        {
            get => Collection;
            set => Collection = value;
        }
    }
}
