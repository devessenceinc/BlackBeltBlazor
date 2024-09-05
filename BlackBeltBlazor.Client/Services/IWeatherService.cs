using BlackBeltBlazor.Client.Models;

namespace BlackBeltBlazor.Client.Services
{
    public interface IWeatherService
    {
        Task<List<WeatherForecast>> GetWeatherAsync();
    }
}
