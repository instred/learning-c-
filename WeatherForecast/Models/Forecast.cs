using System.Text.Json.Serialization;

namespace WeatherForecast.Models
{

    public class ForecastWeather
    {
        [JsonPropertyName("icon")]
        public string? IconCode { get; set;}

        [JsonPropertyName("description")]
        public string? Description { get; set;}


    }

    public class ForecastData
    {
        [JsonPropertyName("valid_date")]
        public required string ValidDate { get; set;}
        
        [JsonPropertyName("temp")]
        public double Temp { get; set;}

        [JsonPropertyName("wind_spd")]
        public double WindSpeed { get; set;}

        [JsonPropertyName("pres")]
        public double Pressure { get; set;}

        [JsonPropertyName("weather")]
        public required List<ForecastWeather> WeatherIconDetails {get; set;}

    }

    public class Forecast
    {
        [JsonPropertyName("data")]
        public required List<ForecastData> Data { get; set; }

        [JsonPropertyName("city_name")]
        public required string CityName { get; set;}

        [JsonPropertyName("country_code")]
        public string? CountryCode {get; set;}

    }


}

