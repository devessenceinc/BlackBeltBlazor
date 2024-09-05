using BlackBeltBlazor.Client.Models;
using BlackBeltBlazor.Client.Services;

namespace BlackBeltBlazor.Services
{
    public class WeatherService : IWeatherService
    {
        public Task<List<WeatherForecast>> GetWeatherAsync()
        {
            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToList());
        }
    }
}
