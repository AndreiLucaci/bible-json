using System.IO;
using System.Threading.Tasks;
using BibleJson.Models;
using BibleJson.Models.Contracts;
using BibleJsonFormatter.Engine.Contracts;

namespace BibleJsonFormatter.Engine.Engines
{
    public class ChapterFormatterEngine : IChapterFormatterEngine
    {
        private readonly IVerseFormatterEngine _verseFormatterEngine;

        public ChapterFormatterEngine(IVerseFormatterEngine verseFormatterEngine)
        {
            _verseFormatterEngine = verseFormatterEngine;
        }

        public async Task<IChapter> Process(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var chapter = new Chapter();

                using (var sr = new StringReader(input))
                {
                    var title = await sr.ReadLineAsync();
                    chapter.Title = title;
                    
                    var titleParts = title.Split(' ');
                    if (titleParts.Length == 2 && int.TryParse(titleParts[1], out var number))
                    {
                        chapter.Number = number;
                    }

                    string line;

                    while (!string.IsNullOrEmpty(line = await sr.ReadLineAsync()))
                    {
                        var verse = await _verseFormatterEngine.Process(line);

                        if (verse == null)
                        {
                            chapter.SubTitle = line;
                        }
                        else
                        {
                            chapter.Collection.Add(verse);
                        }
                    } 
                }

                return chapter;
            }

            return null;
        }
    }
}
