namespace BibleQueryLanguage.Processor.Contracts
{
    public interface IProcessor<out T>
    {
        T Process(string input);
    }
}
