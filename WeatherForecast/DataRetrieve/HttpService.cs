
namespace WeatherForecast.DataRetrieve
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

            string weatherResponse = "";

            try
            {
                using HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                weatherResponse = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error during API call: {ex.Message}");
            }
            
            return weatherResponse;
        }


    }
}