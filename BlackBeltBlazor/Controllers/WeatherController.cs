using Microsoft.AspNetCore.Mvc;
using BlackBeltBlazor.Client.Services;
using System.Diagnostics;
using BlackBeltBlazor.Client.Models;

namespace BlackBeltBlazor.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private readonly IWeatherService _WeatherService;

        public WeatherController(IWeatherService WeatherService)
        {
            _WeatherService = WeatherService;
        }

        [HttpGet]
        public async Task<List<WeatherForecast>> Get()
        {
            return await _WeatherService.GetWeatherAsync();
        }
    }
}
