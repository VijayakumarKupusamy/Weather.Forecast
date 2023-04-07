namespace WeatherForecast.Api
{
    public  static class ServiceExtensions
    {
        public static IServiceCollection AddWeatherForeCast(this IServiceCollection services)
        {
            services.AddSingleton<ITemperature, Temperature>();
            services.AddSingleton<IRainFall, RainFall>();
            services.AddSingleton<IWeatherForecast, WeatherForecast>();
            return services;
        }
    }

}
