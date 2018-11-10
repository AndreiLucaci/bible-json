using System.Collections.Generic;
using BibleJson.Infrastructure.Contracts;

namespace BibleJson.Models.Contracts
{
    public interface IChapter : ITitable, ISubTitable, ICountable, ICollectionable<IVerse>
    {
        IList<IVerse> Verses { get; set; }
    }
}
