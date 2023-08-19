using MyMoviePreferencesApp.Api.DTOs;

namespace MyMoviePreferencesApp.Api.Services;

public interface IMovieService
{
    IEnumerable<MovieDto> GetAllMovies();
    MovieDto GetMovieById(int movieId);
}