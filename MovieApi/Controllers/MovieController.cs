using Microsoft.AspNetCore.Mvc;
using MovieApi.Api.Data;
using MovieApi.Api.Services;
using MovieApi.Api.Models;
using MovieApi.Api.ApiModels;


namespace MovieApi.Api.Controllers;


/// <summary>
/// Controller for managing movie-related operations.
/// </summary>
/// <remarks>
/// This controller is responsible for fetching movie data from an external API and persisting the relevant information to a database.
/// </remarks>
[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private readonly MovieApiService _movieApiService;
    private readonly MovieContext _context;

    public MovieController(MovieApiService movieApiService, MovieContext context) // adicionado 'MovieContext context' no construtor
    {
        _movieApiService = movieApiService;
        _context = context; // adicionada esta linha pro context ser inicializado
    }

    /// <summary>
    /// Fetches popular movies from the TMDb API and saves them to the database.
    /// </summary>
    /// <returns>Returns a success message or an error if the operation fails.</returns>
    /// <response code="200">Returns a success message.</response>
    /// <response code="404">If no movies are found from the API.</response>
    /// <response code="500">If an internal server error occurs.</response>
    [HttpGet("fetch-and-save-popular-movies")]
    public async Task<IActionResult> FetchAndSavePopularMovies()
    {
        var moviesFromApi = await _movieApiService.GetPopularMoviesAsync();

        if (moviesFromApi == null || !moviesFromApi.Any())
        {
            return NotFound("No movies found from the API.");
        }

        foreach (var apiMovie in moviesFromApi)
        {
            var movie = new Movie
            {
                Title = apiMovie.Title,
                Overview = apiMovie.Overview,
                ReleaseDate = DateTime.TryParse(apiMovie.ReleaseDate, out var date) ? date : (DateTime?)null,
                Popularity = apiMovie.Popularity
            };
            _context.Movies.Add(movie);
        }

        await _context.SaveChangesAsync();
        return Ok("Movies have been successfully fetched and saved to the database.");
    }
}