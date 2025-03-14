using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TheirDayBlazor.Pages
{
    public class OpenWeather
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public OpenWeather(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = EnvironmentConfig.GetApiKey(); // <-check .env>
            _baseUrl = "https://api.openweathermap.org/data/2.5/weather";
        }

        public async Task<WeatherResponse?> GetWeatherAsync(string city)
        {
            var url = $"{_baseUrl}?q={city}&appid={_apiKey}&units=imperial";
            return await _httpClient.GetFromJsonAsync<WeatherResponse>(url);
        }
    }

    public class WeatherResponse
    {
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
        public string Name { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }
}
