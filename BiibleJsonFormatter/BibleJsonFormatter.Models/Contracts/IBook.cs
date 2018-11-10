using System.Collections.Generic;
using BibleJson.Infrastructure.Contracts;

namespace BibleJson.Models.Contracts
{
    public interface IBook : ICountable, ICollectionable<IChapter>, ITitable, ISubTitable
    {
        IList<IChapter> Chapters { get; set; }
    }
}
