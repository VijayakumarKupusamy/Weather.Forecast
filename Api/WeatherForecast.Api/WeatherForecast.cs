namespace WeatherForecast.Api
{
    public interface IWeatherForecast:ITemperature, IRainFall
    {
    }
    public class WeatherForecast: IWeatherForecast
    {
        private readonly ITemperature _temperature;
        private readonly IRainFall _rainFall;
        public WeatherForecast(ITemperature temperature,IRainFall rainFall)
        {
            _temperature=temperature;
            _rainFall=rainFall;
        }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public double GetRainFall()
        {
            return _rainFall.GetRainFall();
        }

        public double GetTemperature()
        {
            return _temperature.GetTemperature();
        }
    }
}