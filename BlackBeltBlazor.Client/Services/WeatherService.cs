using BlackBeltBlazor.Client.Models;
using System.Net.Http.Json;

namespace BlackBeltBlazor.Client.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _http;

        public WeatherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<WeatherForecast>> GetWeatherAsync()
        {
            var response = await _http.GetAsync("api/Weather/", HttpCompletionOption.ResponseHeadersRead, CancellationToken.None);
            return await response.Content.ReadFromJsonAsync<List<WeatherForecast>>();
        }
    }
}
