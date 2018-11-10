using System.Threading.Tasks;
using BibleJsonFormatter.Engine.Contracts.BibleContracts;

namespace BibleJsonFormatter.Contracts.Engines
{
    public interface IBibleFormatterEngine
    {
        Task<IBible> GetBibleFromTxtAsync(string fileName);
    }
}
