using MyMoviePreferencesApp.Api.DTOs;

namespace MyMoviePreferencesApp.Api.Services;

public class MovieService : IMovieService
{
    private readonly ApplicationDbContext _dbContext; // ApplicationDbContext es tu DbContext de EF Core

    public MovieService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<MovieDto> GetAllMovies()
    {
        var movies = _dbContext.Movies.ToList(); // Movies DbSet en el DbContext
        var movieDtos = movies.Select(movie => new MovieDto
        {
            MovieID = movie.MovieID,
            Title = movie.Title,
            GenreID = movie.GenreID,
            Director = movie.Director,
            Description = movie.Description
        }).ToList();

        return movieDtos;
    }

    public MovieDto GetMovieById(int movieId)
    {
        var movie = _dbContext.Movies.FirstOrDefault(m => m.MovieID == movieId);
        if (movie == null)
        {
            return null;
        }

        var movieDto = new MovieDto
        {
            MovieID = movie.MovieID,
            Title = movie.Title,
            GenreID = movie.GenreID,
            Director = movie.Director,
            Description = movie.Description
        };

        return movieDto;
    }

    // Implementar otros métodos del IMovieService según las necesidades
}