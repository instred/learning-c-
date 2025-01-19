using System;
using System.IO;

namespace WeatherForecast
{
    public static class DotEnv
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Env file does not exist");
                return;
            }
            // Console.WriteLine(File.ReadAllLines(filePath));

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(
                    '=',
                    StringSplitOptions.RemoveEmptyEntries);
                // Console.WriteLine(parts);
                if (parts.Length != 2)
                {
                    continue;
                }

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }       
    }
}