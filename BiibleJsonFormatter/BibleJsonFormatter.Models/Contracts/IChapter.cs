using System.Collections.Generic;
using BibeJson.Infrastructure.Contracts;

namespace BibleJson.Models.Contracts
{
    public interface IChapter : ITitable, ISubTitable, ICountable, ICollectionable<IVerse>
    {
        IList<IVerse> Verses { get; set; }
    }
}
