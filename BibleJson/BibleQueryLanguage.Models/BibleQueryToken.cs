using BibleQueryLanguage.Models.Contracts;

namespace BibleQueryLanguage.Models
{
    public class BibleQueryToken : IBibleQueryToken
    {
        public string OriginalText { get; set; }

        public string Book { get; set; }

        public string Chapter { get; set; }

        public int? Verse { get; set; }
    }
}
