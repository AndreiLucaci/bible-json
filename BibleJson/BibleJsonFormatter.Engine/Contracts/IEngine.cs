using System.Threading.Tasks;

namespace BibleJsonFormatter.Engine.Contracts
{
    public interface IEngine<T>
    {
        Task<T> Process(string input);
    }
}
