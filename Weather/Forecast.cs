namespace Weather;

public class Forecast : IForecast
{
    public WeatherForecast GetForMarket(string marketId)
    {
        if (marketId == "TW")
        {
            return new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = 20,
                Summary = "Cloudy"
            };
        }

        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now),
            TemperatureC = 25,
            Summary = "Sunny"
        };
    }
}