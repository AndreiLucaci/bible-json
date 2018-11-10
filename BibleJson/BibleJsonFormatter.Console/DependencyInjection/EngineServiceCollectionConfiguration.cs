using BibleJsonFormatter.Engine;
using BibleJsonFormatter.Engine.Contracts;
using BibleJsonFormatter.Engine.Engines;
using Microsoft.Extensions.DependencyInjection;

namespace BibleJsonFormatter.Console.DependencyInjection
{
    public static class EngineServiceCollectionConfiguration
    {
        public static IServiceCollection ConfigureWithEngines(this IServiceCollection services)
        {
            services.AddScoped<IVerseFormatterEngine, VerseFormatterEngine>();
            services.AddScoped<IChapterFormatterEngine, ChapterFormatterEngine>();
            services.AddScoped<IBookFormatterEngine, BookFormatterEngine>();
            services.AddScoped<IBibleFormatterEngine, BibleFormatterEngine>();
            
            return services;
        }
    }
}
