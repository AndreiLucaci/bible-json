using BibleJsonFormatter.Engine.Contracts.BibleContracts;

namespace BibleJsonFormatter.Engine.Models
{
    public class Verse : IVerse
    {
        public int? Number { get; set; }

        public string Text { get; internal set; }
    }
}
