using System;
using System.IO;
using System.Threading.Tasks;
using BibleJsonFormatter.Console.DependencyInjection;
using BibleJsonFormatter.Contracts.Engines;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace BibleJsonFormatter.Console
{
	class Program
	{
        static IServiceCollection GetServiceCollection() => new ServiceCollection();

		static void Main(string[] args)
		{
		    var services =
		        GetServiceCollection()
		            .ConfigureWithEngines()
                    .BuildServiceProvider();

            Process(services).GetAwaiter().GetResult();
		}

	    static async Task Process(IServiceProvider services)
	    {
	        var engine = services.GetService<IBibleFormatterEngine>();
	        try
	        {
	            var bible = await engine.GetBibleFromTxtAsync("source/bible.txt");

	            var serializedObject = JsonConvert.SerializeObject(bible, new JsonSerializerSettings
	            {
	                NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented
	            });


	            await File.WriteAllTextAsync("bible.json", serializedObject);
	        }
	        catch (Exception ex)
	        {
	            System.Console.WriteLine(ex.Message);
	        }
        }
	}
}
