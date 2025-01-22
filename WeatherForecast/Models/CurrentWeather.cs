using System.Text.Json.Serialization;

namespace WeatherForecast.Models
{
    
    public class CurrentData
    {

        [JsonPropertyName("temp")]
        public double Temp { get; set;}

        [JsonPropertyName("wind_spd")]
        public double WindSpeed { get; set;}

        [JsonPropertyName("pres")]
        public double Pressure { get; set;}

        [JsonPropertyName("snowfall")]
        public double Snowfall {get; set;}

        [JsonPropertyName("weather")]
        public Weather? WeatherIconDetails {get; set;}

        [JsonPropertyName("ob_time")]
        public required string ObservationTime { get; set;}

        [JsonPropertyName("city_name")]
        public required string CityName { get; set;}

        [JsonPropertyName("country_code")]
        public required string CountryCode { get; set;}

    }

    public class Current
    {
        [JsonPropertyName("data")]
        public required List<CurrentData> Data { get; set; }
    }
}