

namespace WeatherForecast.InteractiveMenu

{
     public class Option(string name, Func<Task> action)
    {
        public string Name { get; } = name;
        public Func<Task> Action_name { get; } = action;
    }

}