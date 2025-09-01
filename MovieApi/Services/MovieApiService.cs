using Microsoft.Extensions.Configuration;

namespace MovieApi.Api.Services;

public class MovieApiService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public MovieApiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
    }

    public async Task<string> GetPopularMoviesAsync()
    {
        var apiKey = _configuration["ApiSettings:MovieDbApiKey"];
        var response = await _httpClient.GetStringAsync($"movie/popular?api_key={apiKey}");
        return response;
    }
}