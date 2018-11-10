using System.Collections.Generic;
using Newtonsoft.Json;

namespace BibeJson.Infrastructure.Contracts
{
    public interface ICollectionable <T>
    {
        [JsonIgnore]
        IList<T> Collection { get; set; }
    }
}
