using System.Collections.Generic;
using BibleQueryLanguage.Models.Contracts;

namespace BibleQueryLanguage.Processor.Contracts
{
    public interface IBibleQueryTokenProcessor : IProcessor<IEnumerable<IBibleQueryToken>>
    {
    }
}
