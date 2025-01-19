using System;
using System.Net.Http;



namespace WeatherForecast
{
    
    public class HttpService
    {

        private readonly HttpClient client;

        public HttpService()
        {
            HttpClientHandler handler  = new()
            {
                AutomaticDecompression = System.Net.DecompressionMethods.All
            };

            client = new HttpClient();

        }

        public async Task<string> GetAsync(string uri)
        {
            using HttpResponseMessage response = await client.GetAsync(uri);

            return await response.Content.ReadAsStringAsync();

        }


    }
}