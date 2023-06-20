using System;

namespace DILifeTime
{
    public class MySingleton
    {
        private readonly string[] Summaries = new[]
              {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly string currentWeather;

        public MySingleton()
        {
            currentWeather = Summaries[new Random().Next(0, 10)];
        }

        public string GetCurrentWeather()
        {
            return currentWeather;
        }
    }
}
