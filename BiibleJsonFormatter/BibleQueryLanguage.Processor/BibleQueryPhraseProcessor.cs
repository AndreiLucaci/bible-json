using System.Linq;
using BibleQueryLanguage.Models;
using BibleQueryLanguage.Models.Contracts;
using BibleQueryLanguage.Processor.Contracts;

namespace BibleQueryLanguage.Processor
{
    public class BibleQueryPhraseProcessor : IBibleQueryPhraseProcessor
    {
        public IBibleQueryPhrase Process(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var phrase = new BibleQueryPhrase
                {
                    OriginalText = input
                };

                var parts = input.Split(';').Select(i => i.Trim());

                foreach (var part in parts)
                {
                    
                }

                return phrase;
            }

            return null;
        }
    }
}
