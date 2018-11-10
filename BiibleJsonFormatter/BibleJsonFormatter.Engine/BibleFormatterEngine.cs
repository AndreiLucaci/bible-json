using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BibleJsonFormatter.Contracts.Engines;
using BibleJsonFormatter.Engine.Contracts.BibleContracts;
using BibleJsonFormatter.Engine.Contracts.Engines;
using BibleJsonFormatter.Engine.Models;

namespace BibleJsonFormatter.Engine
{
    public class BibleFormatterEngine : IBibleFormatterEngine
    {
        private readonly IBookFormatterEngine _bookFormatterEngine;

        public BibleFormatterEngine(IBookFormatterEngine bookFormatterEngine)
        {
            _bookFormatterEngine = bookFormatterEngine;
        }

        public async Task<IBible> GetBibleFromTxtAsync(string fileName)
        {
            if (File.Exists(fileName))
            {
                var bible = new Bible();

                using (var sr = new StreamReader(fileName))
                {
                    var txt = sr.ReadToEnd();

                    var parts = Regex.Split(txt, $"{Environment.NewLine} {Environment.NewLine}");

                    var counter = default(int);
                    foreach (var part in parts)
                    {
                        var book = await _bookFormatterEngine.Process(part);

                        if (book != null)
                        {
                            book.Number = ++counter;
                            bible.Collection.Add(book);
                        }
                    }
                }

                return bible;
            }

            return null;
        }
    }
}
