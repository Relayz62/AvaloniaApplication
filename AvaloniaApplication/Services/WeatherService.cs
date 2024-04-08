using System.Collections;
using System.Collections.Generic;
using AvaloniaApplication.Models;

namespace AvaloniaApplication.Services;

public class WeatherService
{
    public IEnumerable<Weather> GetWeathers() => new List<Weather>()
    {
        new Weather() { City = "Ryazan", Temperature = 12 },
        new Weather() { City = "Moscow", Temperature = 12 },
    };
}