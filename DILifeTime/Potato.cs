using System;

namespace DILifeTime
{
    public class Potato
    {
        public Potato(MyScoped myScoped, MyTransient myTransient)
        {
            MyTransient = myTransient;
            MyScoped = myScoped;
        }

        public MyTransient MyTransient { get; }
        public MyScoped MyScoped { get; }

        public string GetFalseWeather()
        {
            return $"Scoped: {MyScoped.GetCurrentWeather()}; Transient: {MyTransient.GetCurrentWeather()}";
        }
    }
}
