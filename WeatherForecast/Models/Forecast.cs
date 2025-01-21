using System.Text.Json.Serialization;

namespace WeatherForecast.Models
{

    public class Data
    {
        [JsonPropertyName("valid_date")]
        public string? ValidDate { get; set;}
        
        [JsonPropertyName("temp")]
        public double Temp { get; set;}

    }

    public class ForecastData
    {
        [JsonPropertyName("data")]
        public required List<Data> Data { get; set; }

        [JsonPropertyName("city_name")]
        public string? CityName { get; set;}

    }


}

