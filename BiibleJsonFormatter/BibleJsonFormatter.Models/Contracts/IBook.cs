using System.Collections.Generic;
using BibeJsonFormatter.Infrastructure.Contracts;

namespace BibleJsonFormatter.Models.Contracts
{
    public interface IBook : ICountable, ICollectionable<IChapter>, ITitable, ISubTitable
    {
        IList<IChapter> Chapters { get; set; }
    }
}
