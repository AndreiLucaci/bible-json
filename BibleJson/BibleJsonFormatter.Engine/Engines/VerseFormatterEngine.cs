﻿using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BibleJson.Models;
using BibleJson.Models.Contracts;
using BibleJsonFormatter.Engine.Contracts;

namespace BibleJsonFormatter.Engine.Engines
{
    public class VerseFormatterEngine : IVerseFormatterEngine
    {
        private const string VerseRegexPattern = @"(\d)\. (.*)";
        private static readonly Regex VerseRegex = new Regex(VerseRegexPattern);

        public Task<IVerse> Process(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var match = VerseRegex.Match(input);
                if (match.Success)
                {
                    var verse = new Verse
                    {
                        Number = int.Parse(match.Groups[1].Value),
                        Text = match.Groups[2].Value
                    };
                    
                    return Task.FromResult<IVerse>(verse);
                }
            }

            return Task.FromResult<IVerse>(null);
        }
    }
}
