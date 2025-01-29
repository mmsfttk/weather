namespace Weather;

public interface IForecast
{
    WeatherForecast GetForMarket(string marketId);
}