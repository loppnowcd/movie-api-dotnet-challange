using Microsoft.AspNetCore.Mvc;
using MovieApi.Api.Services;

namespace MovieApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    private readonly MovieApiService _movieApiService;

    public MovieController(MovieApiService movieApiService)
    {
        _movieApiService = movieApiService;
    }

    [HttpGet("fetch-and-save-popular-movies")]
    public async Task<IActionResult> FetchAndSavePopularMovies()
    {
        var response = await _movieApiService.GetPopularMoviesAsync();
        return Ok(response);
    }
}