using System.Collections.Generic;
using BibeJsonFormatter.Infrastructure.Contracts;

namespace BibleJsonFormatter.Models.Contracts
{
    public interface IBible : ICollectionable<IBook>, ITitable
    {
        IList<IBook> Books { get; set; }
    }
}
