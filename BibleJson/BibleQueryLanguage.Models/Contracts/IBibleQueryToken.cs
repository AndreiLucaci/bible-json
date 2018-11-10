using BibleJson.Infrastructure.Contracts;

namespace BibleQueryLanguage.Models.Contracts
{
    public interface IBibleQueryToken : IOriginalText
    {
        string Book { get; set; }
        string Chapter { get; set; }
        int? Verse { get; set; }
    }
}
