using System.Text;
using AvaloniaApplication.GeocodingUtility.Models;
using Newtonsoft.Json;

namespace AvaloniaApplication.GeocodingUtility.Providers;

public class GeocodingProvider
{
    private const string BASE_ADDRESS = "http://geocoding-api.open-meteo.com/v1/search";
    public GeocodingProvider()
    {
        _httpClient = new();
    }
    private readonly HttpClient _httpClient;

    public T Get<T>(string name, int count)
    {
        var json = GetResults(name, count).Result;
        var model = JsonConvert.DeserializeObject<T>(json);
        return model;
    }

    private Task<string> GetResults(string name, int count)
    {
        var parametersBuilder = new StringBuilder();
        parametersBuilder.Append(BASE_ADDRESS);
        parametersBuilder.Append($"?name={name}");
        parametersBuilder.Append($"&count={count}");
        parametersBuilder.Append($"&language=ru");
        parametersBuilder.Append($"&format=json");

        _httpClient.BaseAddress = new Uri($"{parametersBuilder}");
        return _httpClient.GetStringAsync(_httpClient.BaseAddress);
    }
}