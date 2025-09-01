using Microsoft.Extensions.Configuration;
using MovieApi.Api.ApiModels;
using System.Text.Json;

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

    // Este método deve retornar uma lista de MovieApiResult
    public async Task<List<MovieApiResult>?> GetPopularMoviesAsync()
    {
        try
        {
            var apiKey = _configuration["ApiSettings:MovieDbApiKey"];
            var response = await _httpClient.GetStringAsync($"movie/popular?api_key={apiKey}");
            var movieResponse = JsonSerializer.Deserialize<MovieApiResponse>(response);
            return movieResponse?.Results;
        }
        catch (HttpRequestException e)
        {
            // Aqui você pode logar o erro para saber o que aconteceu
            Console.WriteLine($"Error during API call: {e.Message}");
            return null; // Retorna nulo para o controller, que irá lidar com o erro
        }
    }
}