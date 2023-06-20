using Microsoft.AspNetCore.Mvc;

namespace DILifeTime.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public MyTransient MyTransient { get; }
    public MyScoped MyScoped { get; }
    public MySingleton MySingleton { get; }
    public Potato Potato { get; }

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MyTransient myTransient, MyScoped myScoped, MySingleton mySingleton, Potato potato)
    {
        _logger = logger;
        MyTransient = myTransient;
        MyScoped = myScoped;
        MySingleton = mySingleton;
        Potato = potato;
    }


    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet(Name = "GetCurrentWeather")]
    public String GetCurrentWeather()
    {
        var result = $"Singleton: {MySingleton.GetCurrentWeather()}; Scoped: {MyScoped.GetCurrentWeather()}; Transient: {MyTransient.GetCurrentWeather()}; \n False weather {Potato.GetFalseWeather()}";
        return result;
    }
}
