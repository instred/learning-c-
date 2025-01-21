using WeatherForecast.Models;
using System.Text.Json;

namespace WeatherForecast.DataRetrieve
{
    
    public class Functions
    {
        
        private static readonly string base_uri = "http://api.weatherbit.io/v2.0/";
        static readonly HttpService client = new();

        public static void GoBack()
        {
            Console.WriteLine("Press Esc to go back");
            while (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Press Esc to go back");
            }

        }

        public async static Task GetForecast(string location, string? country, bool hasCountry, string api_key, Func<Task> callback)
        {
            
            string forecast_uri = base_uri + $"forecast/daily?key={api_key}&city={location}";
            if (hasCountry)
            {
                forecast_uri += $",{country}";
            }

            Console.Clear();
            Console.WriteLine(forecast_uri);

            string response = await client.GetAsync(forecast_uri);

            if (JsonSerializer.Deserialize<ForecastData>(response) is not ForecastData weatherResponse)
            {
                Console.WriteLine("Failed to parse weather data");
                return;
            }

            Console.WriteLine(weatherResponse.CityName);
            foreach(var item in weatherResponse.Data)
            {
                Console.WriteLine($"Date: {item.ValidDate}, Temp: {item.Temp}");

            }

            GoBack();
            await callback();

            return;
        }
        // public static ForecastData GetAlerts(string location, string? country, string api_key)
        // {
        //     string alerts_uri = base_uri + "alerts?key={api_key}&";
        //     Console.WriteLine(alerts_uri);
            
        // }
        // public static ForecastData GetAirQuality(string location, string? country, string api_key)
        // {
        //     string airquality_uri = base_uri + "current/airquality?key={api_key}&";
        //     Console.WriteLine(airquality_uri);
            
        // }

    }
}