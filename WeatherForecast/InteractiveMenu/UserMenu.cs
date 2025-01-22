using WeatherForecast.DataRetrieve;

namespace WeatherForecast.InteractiveMenu
{

    public class UserMenu
    {
        private static List<Option> options = [];

        public static async Task ShowMenu(string location, string? country, bool hasCountry, string api_key)
        {

            // add option to change city
            // show aditional weather features (ascii icon, chart?)
            

            options =
            [
                new Option("Show current weather", async () => await Functions.GetCurrentWeather(
                    location, 
                    country, 
                    hasCountry, 
                    api_key,
                    () => ShowMenu(location, country, hasCountry, api_key))),
                new Option("Show severe weather alerts", async () => await Functions.GetAlerts(
                    location, 
                    country, 
                    hasCountry, 
                    api_key,
                    () => ShowMenu(location, country, hasCountry, api_key))),
                new Option("Show weather forecast for next days", async () => await Functions.GetForecast(
                    location, 
                    country, 
                    hasCountry, 
                    api_key,
                    () => ShowMenu(location, country, hasCountry, api_key))),
                new Option("Exit", async () => {
                    Environment.Exit(0);
                    await Task.CompletedTask;
                    })
            ];

            int idx = 0;

            WriteMenu(options, options[idx]);

            ConsoleKeyInfo keyInfo;

            do 
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (idx + 1 < options.Count)
                    {
                        idx ++;
                        WriteMenu(options, options[idx]);
                    }
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (idx - 1 >= 0)
                    {
                        idx --;
                        WriteMenu(options, options[idx]);
                    }
                }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    await options[idx].Action_name.Invoke();
                    idx = 0;
                }
                
            } while (keyInfo.Key != ConsoleKey.X);

            Console.ReadKey();
        }

        
        public static void WriteMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            
            Console.WriteLine("Press Esc to go back");
            while (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Press Esc to go back");
            }
            // Thread.Sleep(2000);
            Console.Clear();
            WriteMenu(options, options.First());

        }

        public static void WriteMenu (List<Option> options, Option selected)
        {
            Console.Clear();
            // Console.WriteLine(selected.Name);
            foreach (var option in options)
            {
                if (option == selected)
                {
                    Console.Write(" > ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine(option.Name);
            }

        }
    }
}