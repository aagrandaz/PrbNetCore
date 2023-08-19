using MyMoviePreferencesApp.Api.DTOs;

namespace MyMoviePreferencesApp.Api.Services;

public interface IPreferenceService
{
    PreferenceDto AddUserPreference(UserPreferenceDto userPreferenceDto);
    IEnumerable<PreferenceDto> GetUserPreferences(int userId);
}