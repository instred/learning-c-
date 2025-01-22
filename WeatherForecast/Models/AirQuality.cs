using System.Text.Json.Serialization;

namespace WeatherForecast.Models
{

    public class AirQualityData
    {
        [JsonPropertyName("aqi")]
        public double AirQualityIndex { get; set;}
        
        [JsonPropertyName("mold_level")]
        public double MoldLevel { get; set;}
    
        [JsonPropertyName("o3")]
        public double SurfaceO3 { get; set;}

        [JsonPropertyName("so2")]
        public double SurfaceSO2 { get; set;}

        [JsonPropertyName("no2")]
        public double SurfaceNO2 { get; set;}

        [JsonPropertyName("co")]
        public double SurfaceCO { get; set;}
    }

    public class AirQuality
    {
        [JsonPropertyName("data")]
        public required List<AirQualityData> Data { get; set; }

        [JsonPropertyName("city_name")]
        public required string CityName { get; set;}
        
        [JsonPropertyName("country_code")]
        public string? CountryCode {get; set;}

    }


}
