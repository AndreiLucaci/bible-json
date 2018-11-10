using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BibleJsonFormatter.Engine.Contracts.BibleContracts;
using BibleJsonFormatter.Engine.Contracts.Engines;
using BibleJsonFormatter.Engine.Models;

namespace BibleJsonFormatter.Engine.Engines
{
    public class BookFormatterEngine : IBookFormatterEngine
    {
        private readonly IChapterFormatterEngine _chapterFormatterEngine;

        public BookFormatterEngine(IChapterFormatterEngine chapterFormatterEngine)
        {
            _chapterFormatterEngine = chapterFormatterEngine;
        }

        public async Task<IBook> Process(string input)
        {
            var book = new Book();

            if (!string.IsNullOrEmpty(input))
            {
                using (var sr = new StringReader(input))
                {
                    var title = await sr.ReadLineAsync();
                    book.Title = title;

                    var rest = await sr.ReadToEndAsync();
                    var parts = Regex.Split(rest, $"{Environment.NewLine}{Environment.NewLine}").Where(i => !string.IsNullOrEmpty(i)).Select(i => i.Trim());

                    foreach (var part in parts)
                    {
                        var chapter = await _chapterFormatterEngine.Process(part);

                        if (chapter != null)
                        {
                            book.Collection.Add(chapter);
                        }
                    }
                }
            }

            return book;
        }
    }
}
