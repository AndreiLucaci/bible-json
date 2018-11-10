using BibleJson.Models.Contracts;

namespace BibleJson.Models
{
    public class Verse : IVerse
    {
        public int? Number { get; set; }

        public string Text { get; set; }
    }
}
