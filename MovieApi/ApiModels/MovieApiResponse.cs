using System.Text.Json.Serialization;

namespace MovieApi.Api.ApiModels;

public class MovieApiResponse
{
    [JsonPropertyName("results")]
    public List<MovieApiResult>? Results { get; set; }
}