using MyMoviePreferencesApp.DataAccess.Entities;
using MyMoviePreferencesApp.DataAccess.MyMoviePreferencesApp.DataAccess;

namespace MyMoviePreferencesApp.DataAccess.Repositories;

public class PreferenceRepository : IPreferenceRepository
{
    private readonly ApplicationDbContext _dbContext;

    public PreferenceRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Preference AddUserPreference(UserPreferenceDto userPreferenceDto)
    {
        var preference = new Preference
        {
            UserID = userPreferenceDto.UserID,
            GenreID = userPreferenceDto.GenreID
        };

        _dbContext.Preferences.Add(preference);
        _dbContext.SaveChanges();

        return preference;
    }
}