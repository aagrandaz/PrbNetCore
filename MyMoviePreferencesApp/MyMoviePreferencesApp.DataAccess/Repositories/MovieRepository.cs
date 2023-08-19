using MyMoviePreferencesApp.DataAccess.Entities;
using MyMoviePreferencesApp.DataAccess.MyMoviePreferencesApp.DataAccess;

namespace MyMoviePreferencesApp.DataAccess.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _dbContext;

    public MovieRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Movie> GetAll()
    {
        return _dbContext.Movies.ToList();
    }

    public Movie GetById(int movieId)
    {
        return _dbContext.Movies.FirstOrDefault(m => m.MovieID == movieId);
    }
}
