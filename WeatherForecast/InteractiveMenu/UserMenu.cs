using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;

namespace WeatherForecast.InteractiveMenu
{

    public class UserMenu
    {

        public static List<Option> options;

        public static void ShowMenu()
        {

            options =
            [
                new Option("Show weather forecast for next days", () => WriteMessage("a")),
                new Option("Show current air quality", () => WriteMessage("b")),
                new Option("Show any weather alerts around", () => WriteMessage("c")),
                new Option("Exit", () => Environment.Exit(0)),
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
                    options[idx].Action_name.Invoke();
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