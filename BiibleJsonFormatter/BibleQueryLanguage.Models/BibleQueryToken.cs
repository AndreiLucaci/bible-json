using BibleQueryLanguage.Models.Contracts;

namespace BibleQueryLanguage.Models
{
    public class BibleQueryToken : IBibleQueryToken
    {
        public string OriginalText { get; set; }
    }
}
