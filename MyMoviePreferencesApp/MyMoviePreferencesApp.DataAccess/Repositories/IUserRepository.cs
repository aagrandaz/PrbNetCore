using MyMoviePreferencesApp.DataAccess.Entities;

namespace MyMoviePreferencesApp.DataAccess.Repositories;

public interface IUserRepository
{
    User CreateUser(UserRegistrationDto registrationDto);
    User GetUserById(int userId);
    // Otros métodos relacionados con usuarios
}