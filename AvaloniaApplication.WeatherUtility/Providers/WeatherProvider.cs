namespace AvaloniaApplication.WeatherUtility.Providers;

public class WeatherProvider
{
    private readonly HttpClient _httpClient;

    private const string BASE_ADDRESS = "https://api.open-meteo.com/v1/forecast/";
    public WeatherProvider()
    {
        _httpClient = new()
        {
            BaseAddress = new(BASE_ADDRESS)
        };
    }
    
    
}