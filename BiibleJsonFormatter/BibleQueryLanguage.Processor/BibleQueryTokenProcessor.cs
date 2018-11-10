using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BibleQueryLanguage.Models;
using BibleQueryLanguage.Models.Contracts;
using BibleQueryLanguage.Processor.Contracts;

namespace BibleQueryLanguage.Processor
{
    public class BibleQueryTokenProcessor : IBibleQueryTokenProcessor
    {
        public IEnumerable<IBibleQueryToken> Process(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var tokenList = new List<IBibleQueryToken>();

                var parts = input.Split(' ').Select(i => i.Trim()).ToList();

                if (parts.Count == 1)
                {
                    tokenList.Add(
                        new BibleQueryToken
                        {
                            OriginalText = input,
                            Book = parts[1]
                        }
                    );
                }

                if (parts.Count == 2)
                {
                    if (Regex.IsMatch(parts[1], "\\d+?"))
                    {
                        tokenList.Add(
                            new BibleQueryToken
                            {
                                OriginalText = input,
                                Book = string.Join(" ", parts)
                            }
                        );
                    }
                    else
                    {
                        
                    }
                }

            }

            return null;
        }
    }
}
