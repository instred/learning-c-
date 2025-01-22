using System.Text.Json.Serialization;

namespace WeatherForecast.Models
{

    public class Alert
    {
        [JsonPropertyName("title")]
        public required string Title;
        
        [JsonPropertyName("severity")]
        public required string Serverity;
        
        [JsonPropertyName("description")]
        public required string Description;
        
        [JsonPropertyName("effective_utc")]
        public required string EffectiveUTC;
        
        [JsonPropertyName("regions")]
        public List<string>? Regions;


    }

    public class CurrentAlerts
    {
        [JsonPropertyName("alerts")]
        public required List<Alert> Alerts;

        [JsonPropertyName("city_name")]
        public required string CityName;

        [JsonPropertyName("country_Code")]
        public string? CountryName;
        

    }

}