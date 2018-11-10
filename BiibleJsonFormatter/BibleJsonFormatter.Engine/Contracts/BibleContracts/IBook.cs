using System.Collections.Generic;

namespace BibleJsonFormatter.Engine.Contracts.BibleContracts
{
    public interface IBook : ICountable, ICollectionable<IChapter>, ITitable, ISubTitable
    {
        IList<IChapter> Chapters { get; }
    }
}
