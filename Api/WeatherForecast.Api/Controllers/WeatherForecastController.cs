using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecast _weatherForecast;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecast weatherForecast)
        {
            _logger = logger;
            _weatherForecast = weatherForecast;
        }

        [HttpGet("temperature")]
        public double GetTemperature()
        {
            return _weatherForecast.GetTemperature();
        }

        [HttpGet("rainfall")]
        public double GetRainFall()
        {
            return _weatherForecast.GetRainFall();
        }
    }
}