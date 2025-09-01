namespace MovieApi.Api.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Overview { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public double? Popularity { get; set; }
}