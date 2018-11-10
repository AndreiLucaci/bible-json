using System.Collections.Generic;

namespace BibleJsonFormatter.Engine.Contracts.BibleContracts
{
    public interface IChapter : ITitable, ISubTitable, ICountable, ICollectionable<IVerse>
    {
        IList<IVerse> Verses { get; }
    }
}
