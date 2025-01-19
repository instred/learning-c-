using System;

namespace WeatherForecast
{

    public class Program
    {
        public async static Task Main(string[] args)
        {
            var root = Directory.GetCurrentDirectory();
            var env_path = Path.Combine(root, ".env");
            // Console.WriteLine(env_path);
            DotEnv.Load(env_path);

            string base_uri = "https://api.weatherbit.io/v2.0/forecast/daily?city=Raleigh,NC&key=";
            

            string? api_key = Environment.GetEnvironmentVariable("API_KEY");
            string api_uri = base_uri + api_key;

            HttpClient client = new();
            // Console.WriteLine(api_uri);
            await client.GetAsync(api_uri);
        }
    }
}