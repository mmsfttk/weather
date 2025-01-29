using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IForecast _forecast;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(
        IForecast forecast,
        ILogger<WeatherForecastController> logger)
    {
        _forecast = forecast;
        _logger = logger;
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

    [HttpGet("{marketId}")]
    public WeatherForecast GetForMarket(string marketId)
    {
        return _forecast.GetForMarket(marketId);
    }
}
