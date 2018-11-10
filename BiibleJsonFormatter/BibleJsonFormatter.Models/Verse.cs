using BibleJsonFormatter.Models.Contracts;

namespace BibleJsonFormatter.Models
{
    public class Verse : IVerse
    {
        public int? Number { get; set; }

        public string Text { get; set; }
    }
}
