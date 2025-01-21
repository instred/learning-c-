using System;
using System.Text.Json;
using WeatherForecast.InteractiveMenu;

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

            string base_uri = "http://api.weatherbit.io/v2.0/forecast/daily?city=Kolonowskie&key=";

            string? api_key = Environment.GetEnvironmentVariable("API_KEY");
            string api_uri = base_uri + api_key;

            // Console.WriteLine(api_uri);

            HttpService client = new();
            string response = await client.GetAsync(api_uri);

            // if (JsonSerializer.Deserialize<WeatherResponse>(response) is not WeatherResponse weatherResponse)
            // {
            //     Console.WriteLine("Failed to parse weather data");
            //     return;
            // }

            // Console.WriteLine(weatherResponse.CityName);
            // foreach(var item in weatherResponse.Data)
            // {
            //     Console.WriteLine($"Date: {item.ValidDate}, Temp: {item.Temp}");

            // }

            UserMenu.ShowMenu();
        }
    }
}