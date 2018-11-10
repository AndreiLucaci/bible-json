using System.Collections.Generic;
using BibeJsonFormatter.Infrastructure.Contracts;

namespace BibleJsonFormatter.Models.Contracts
{
    public interface IChapter : ITitable, ISubTitable, ICountable, ICollectionable<IVerse>
    {
        IList<IVerse> Verses { get; set; }
    }
}
