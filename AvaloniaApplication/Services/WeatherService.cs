using System.Collections;
using System.Collections.Generic;
using AvaloniaApplication.Models;

namespace AvaloniaApplication.Services;

public class WeatherService
{
    public IEnumerable<WeatherModel> GetWeathers() => new List<WeatherModel>()
    {
        new WeatherModel() { City = "Ryazan", Temperature = 12 },
        new WeatherModel() { City = "Moscow", Temperature = 12 },
    };
}