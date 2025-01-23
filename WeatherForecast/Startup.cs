using WeatherForecast.InteractiveMenu;

namespace WeatherForecast
{
    
    public class Startup
    {

        
        public static async Task ProgramStart(bool greetUser)
        {

            if (greetUser)
            {
                GreetUser();
            }
            Console.Clear();
            Tuple<string, string> location_pair = GetInput();
            string location = location_pair.Item1;
            string country = location_pair.Item2;
            bool hasCountry = false;

            if (country != "")
            {
                hasCountry = true;
            }

            var root = Directory.GetCurrentDirectory();
            var env_path = Path.Combine(root, ".env");
            DotEnv.Load(env_path);

            string? api_key = Environment.GetEnvironmentVariable("API_KEY");
            if (string.IsNullOrEmpty(api_key))
            {
                Console.WriteLine("Failed to retrieve API key from .env file");
                return;
            }

            await UserMenu.ShowMenu(location, country, hasCountry, api_key);

            

        }

        public static void GreetUser()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Weather App.\nCurrently supported operations are: Weaher Forecast, Nearest Alerts Check, Check current Air Quality");
            Console.WriteLine("You can give location with city name. Country is optional");
            Console.WriteLine("Press a button to start");
            Console.ReadKey();
        }

        public static Tuple<string,string> GetInput()
        {
            Console.WriteLine("Enter City as your location");
            string? location = Console.ReadLine();

            while (string.IsNullOrEmpty(location) || !location.All(char.IsLetter))
            {
                Console.WriteLine("Please enter valid location");
                location = Console.ReadLine();
            }    

            Console.WriteLine("Enter Country in 2 letter format (optional - press enter to skip)");
            string? country = Console.ReadLine();
        
            if (string.IsNullOrEmpty(country))
            {
                country = "";
            }

            while (country == null || !country.All(char.IsLetter))
            {
                Console.WriteLine("Enter valid country or skip it");
                country = Console.ReadLine();
            }

            // Console.WriteLine(location);
            // Console.WriteLine(country);

            Tuple<string, string> location_pair = new(location, country);

            return location_pair;

        }
    }
}