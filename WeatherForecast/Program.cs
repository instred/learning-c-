using System;

namespace WeatherForecast
{
    public class Program
    {
        
        public static async Task Main(string[] args)
        {
            await Startup.ProgramStart();
        }
    }
}