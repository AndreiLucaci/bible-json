using System.Collections.Generic;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Engine.Contracts
{
    public interface ICollectionable <T>
    {
        [JsonIgnore]
        IList<T> Collection { get; }
    }
}
