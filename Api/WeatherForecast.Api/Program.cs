var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<WeatherForecast.Api.ITemperature, WeatherForecast.Api.Temperature>();
builder.Services.AddSingleton<WeatherForecast.Api.IRainFall, WeatherForecast.Api.RainFall>();
builder.Services.AddSingleton<WeatherForecast.Api.IWeatherForecast, WeatherForecast.Api.WeatherForecast>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
