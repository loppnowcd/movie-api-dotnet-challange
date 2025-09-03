using System.ComponentModel.DataAnnotations;

namespace MovieApi.Api.Models;

public class Movie
{
    public int Id { get; set; }
    [Required] // garante que o titulo nao seja nulo
    public string? Title { get; set; }
    [StringLength(500, ErrorMessage = "A sinopse deve ter no máximo 500 caracteres.")]
    public string? Overview { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public double? Popularity { get; set; }
}