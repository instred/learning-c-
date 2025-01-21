

namespace WeatherForecast.InteractiveMenu

{
    public class Option(string n, Action action_n)
    {
        public string Name { get; } = n;
        public Action Action_name { get; } = action_n;
    }
    
}