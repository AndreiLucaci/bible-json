using System.Threading.Tasks;
using BibleJson.Models.Contracts;

namespace BibleJsonFormatter.Engine.Contracts
{
    public interface IBibleFormatterEngine
    {
        Task<IBible> GetBibleFromTxtAsync(string fileName);
    }
}
