using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] arsgs)
        {
            swaggerClient client = new("https://localhost:44333", new HttpClient());

            var records = await client.WeatherForecastAsync();

            foreach (var r in records)
            {
                Console.WriteLine(
                   $"{r.Date}: {r.TemperatureC} { r.Summary}"
                   );

                //Console.WriteLine($"{ r.Date }: { r.Summary }");
        }
        }
    }
}
