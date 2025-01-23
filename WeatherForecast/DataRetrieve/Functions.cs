using WeatherForecast.Models;
using System.Text.Json;
using System.Globalization;

namespace WeatherForecast.DataRetrieve
{
    
    public class Functions
    {
        
        private static readonly string base_uri = "http://api.weatherbit.io/v2.0/";
        static readonly HttpService client = new();

        public async static Task GetCurrentWeather(string location, string? country, bool hasCountry, string api_key, Func<Task> callback)
        {

            string currentweather_uri = base_uri + $"current?key={api_key}&city={location}";
            if (hasCountry)
            {
                currentweather_uri += $",{country}";
            }

            Console.Clear();
            // Console.WriteLine(currentweather_uri);

            string response = await client.GetAsync(currentweather_uri);

            if (JsonSerializer.Deserialize<Current>(response) is not Current weatherResponse)
            {
                Console.WriteLine("Failed to parse weather data");
                return;
            }


            ShowCurrentWeather(weatherResponse);
            GoBack();
            await callback();

            return;
            
        }
        public async static Task GetAlerts(string location, string? country, bool hasCountry, string api_key, Func<Task> callback)
        {
            string alerts_uri = base_uri + $"alerts?key={api_key}&city={location}";
            if (hasCountry)
            {
                alerts_uri += $",{country}";
            }

            Console.Clear();
            // Console.WriteLine(alerts_uri);

            string response = await client.GetAsync(alerts_uri);

            if (JsonSerializer.Deserialize<CurrentAlerts>(response) is not CurrentAlerts weatherResponse)
            {
                Console.WriteLine("Failed to parse weather data");
                return;
            }

            ShowAlerts(weatherResponse);
            GoBack();
            await callback();

            return;
            
        }
        public async static Task GetForecast(string location, string? country, bool hasCountry, string api_key, Func<Task> callback)
        {
            
            string forecast_uri = base_uri + $"forecast/daily?key={api_key}&city={location}";
            if (hasCountry)
            {
                forecast_uri += $",{country}";
            }

            Console.Clear();
            // Console.WriteLine(forecast_uri);

            string response = await client.GetAsync(forecast_uri);

            if (JsonSerializer.Deserialize<Forecast>(response) is not Forecast weatherResponse)
            {
                Console.WriteLine("Failed to parse weather data");
                return;
            }

            ShowForecastData(weatherResponse);
            GoBack();
            await callback();

            return;
        }

        public static void ShowCurrentWeather(Current currentWeather)
        {
            foreach (var data in currentWeather.Data)
            {
                Console.Write(data.CityName);
                if (!string.IsNullOrEmpty(data.CountryCode))
                {   
                    Console.Write($" {data.CountryCode}");
                }
                Console.WriteLine("\nCurrent weather informations for your location:\n");
                Console.WriteLine($"Temperature: {data.Temp}C");
                Console.WriteLine($"Wind speed : {data.WindSpeed}(m/s)");
                Console.WriteLine($"Pressure: {data.Pressure}hpa");
                Console.WriteLine($"Snowfall level: {data.Snowfall}mm");
                Console.WriteLine($"Last observation time: {data.ObservationTime}");
            
                // Add icon + info 
            }
        }

        public static void ShowAlerts(CurrentAlerts nearAlerts)
        {
            Console.Write(nearAlerts.CityName);
            if (!string.IsNullOrEmpty(nearAlerts.CountryName))
            {   
                Console.Write($",{nearAlerts.CountryName}");
            }
            Console.WriteLine();
            if (nearAlerts.Alerts == null)
            {
                Console.WriteLine("No alerts found for this location");
                return;
            }
            foreach(var data in nearAlerts.Alerts)
            {
                Console.WriteLine("\nAlerts found near your location:\n");
                Console.WriteLine($"Title: {data.Title}");
                Console.WriteLine($"UTC time that alert was issued: {data.EffectiveUTC}");
                Console.WriteLine($"Severity of the weather phenomena - Either 'Advisory', 'Watch', or 'Warning': {data.Serverity}");
                Console.WriteLine($"Affected regions: {data.Regions}");
                Console.WriteLine($"Alert description: {data.Description}");
            }
        }
        public static void ShowForecastData(Forecast forecast)
        {
            Console.Write(forecast.CityName);
            if (!string.IsNullOrEmpty(forecast.CountryCode))
            {   
                Console.Write($",{forecast.CountryCode}");
            }
            Console.WriteLine("\n");
            foreach(var data in forecast.Data)
            {   
                if (data.ValidDate != null)
                {
                    GetDayOfWeek(data.ValidDate);
                }
                Console.Write($", {data.ValidDate}\n");
                Console.WriteLine($"Temperature: {data.Temp}C");
                Console.WriteLine($"Wind speed : {data.WindSpeed}(m/s)");
                Console.WriteLine($"Pressure: {data.Pressure}hpa");
                Console.WriteLine($"Snowfall level: {data.Snowfall}mm");

                Console.WriteLine();
            }
            

            // add more displayed info + icon 
        }
        public static void GoBack()
        {
            Console.WriteLine("\nPress Esc to go back");
            while (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Press Esc to go back");
            }

        }

        public static void GetDayOfWeek(string date)
        {
            DateTime dateTime;

            try
            {
                dateTime = DateTime.Parse(date, CultureInfo.InvariantCulture);
                Console.Write(dateTime.ToString("ddd", new CultureInfo("en-EN")));
            }

            catch (FormatException)
            {
                Console.WriteLine("Unable to convert {0} to a date.", date);
            }

            
        }
    }
}