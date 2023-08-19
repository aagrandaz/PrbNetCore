using MyMoviePreferencesApp.Api.DTOs;

namespace MyMoviePreferencesApp.Api.Services;

public interface IUserServices
{
    UserDto RegisterUser(UserRegistrationDto registrationDto);
    UserDto GetUserById(int userId);   
}