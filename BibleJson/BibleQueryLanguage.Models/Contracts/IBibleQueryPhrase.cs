using System.Collections.Generic;
using BibleJson.Infrastructure.Contracts;

namespace BibleQueryLanguage.Models.Contracts
{
    public interface IBibleQueryPhrase : IOriginalText, ICollectionable<IBibleQueryToken>
    {
        IList<IBibleQueryToken> Tokens { get; set; }
    }
}
