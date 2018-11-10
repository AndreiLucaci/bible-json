using System.Collections.Generic;

namespace BibleJsonFormatter.Engine.Contracts.BibleContracts
{
    public interface IBible : ICollectionable<IBook>, ITitable
    {
        IList<IBook> Books { get; }
    }
}
