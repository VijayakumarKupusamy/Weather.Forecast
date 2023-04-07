namespace WeatherForecast.Api
{
    public interface ITemperature
    {
        double GetTemperature();
    }
    public class Temperature : ITemperature
    {
        public double GetTemperature()
        {
            return 37.7;
        }
    }

    public interface IRainFall
    {
        double GetRainFall();
    }
    public class RainFall : IRainFall
    {
        public double GetRainFall()
        {
            return 5.5;
        }
    }
}