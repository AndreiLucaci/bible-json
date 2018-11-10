using System.Threading.Tasks;

namespace BibleJsonFormatter.Engine.Contracts.Engines
{
    public interface IEngine<T>
    {
        Task<T> Process(string input);
    }
}
