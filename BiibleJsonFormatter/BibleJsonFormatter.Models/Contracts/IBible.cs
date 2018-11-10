using System.Collections.Generic;
using BibleJson.Infrastructure.Contracts;

namespace BibleJson.Models.Contracts
{
    public interface IBible : ICollectionable<IBook>, ITitable
    {
        IList<IBook> Books { get; set; }
    }
}
