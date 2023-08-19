using Microsoft.AspNetCore.Mvc;
using MyMoviePreferencesApp.Api.DTOs;
using MyMoviePreferencesApp.Api.Services;

namespace MyMoviePreferencesApp.Api.Controllers;

[ApiController]
[Route("api/movies")]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<MovieDto>> GetMovies()
    {
        var movies = _movieService.GetAllMovies();
        return Ok(movies);
    }

    [HttpGet("{movieId}")]
    public ActionResult<MovieDto> GetMovie(int movieId)
    {
        var movie = _movieService.GetMovieById(movieId);
        if (movie == null)
            return NotFound();

        return Ok(movie);
    }
}