using MyMoviePreferencesApp.Api.DTOs;

namespace MyMoviePreferencesApp.Api.Services;

public class PreferenceService : IPreferenceService
{
    // Inyectar cualquier dependencia necesaria, como repositorios, aquí

    public PreferenceDto AddUserPreference(UserPreferenceDto userPreferenceDto)
    {
        // Implementa la lógica para agregar la preferencia de un usuario y retornar el DTO correspondiente
    }

    public IEnumerable<PreferenceDto> GetUserPreferences(int userId)
    {
        // Implementa la lógica para obtener las preferencias de un usuario y retornar DTOs correspondientes
    }

    // Implementa otros métodos del IPreferenceService según tus necesidades
}