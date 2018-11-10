using BibleQueryLanguage.Models.Contracts;
using BibleQueryLanguage.Processor.Contracts;

namespace BibleQueryLanguage.Processor
{
    public class BibleQueryTokenProcessor : IBibleQueryTokenProcessor
    {
        public IBibleQueryToken Process(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                
            }

            return null;
        }
    }
}
