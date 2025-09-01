using System.Text.Json.Serialization;

namespace MovieApi.Api.ApiModels;

public class MovieApiResult
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Overview { get; set; }
    [JsonPropertyName("release_date")]
    public string? ReleaseDate { get; set; }
    public double? Popularity { get; set; }
}