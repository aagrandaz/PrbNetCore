using MyMoviePreferencesApp.DataAccess.Entities;

namespace MyMoviePreferencesApp.DataAccess.Repositories;

public interface IPreferenceRepository
{
    Preference AddUserPreference(UserPreferenceDto userPreferenceDto);
    IEnumerable<Preference> GetUserPreferences(int userId);
}
