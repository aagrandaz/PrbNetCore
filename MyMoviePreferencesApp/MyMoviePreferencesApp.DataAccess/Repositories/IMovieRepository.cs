using MyMoviePreferencesApp.DataAccess.Entities;

namespace MyMoviePreferencesApp.DataAccess.Repositories;

public interface IMovieRepository
{
    IEnumerable<Movie> GetAll();
    Movie GetById(int movieId);
}