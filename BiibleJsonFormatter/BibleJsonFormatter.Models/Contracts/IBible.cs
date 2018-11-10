using System.Collections.Generic;
using BibeJson.Infrastructure.Contracts;

namespace BibleJson.Models.Contracts
{
    public interface IBible : ICollectionable<IBook>, ITitable
    {
        IList<IBook> Books { get; set; }
    }
}
