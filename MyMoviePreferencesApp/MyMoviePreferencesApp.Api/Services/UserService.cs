using MyMoviePreferencesApp.Api.DTOs;
using MyMoviePreferencesApp.DataAccess.Repositories;

namespace MyMoviePreferencesApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto RegisterUser(UserRegistrationDto registrationDto)
        {
            // Aquí realizar validaciones y lógica adicional antes de registrar al usuario

            var newUser = new User
            {
                Username = registrationDto.Username,
                Email = registrationDto.Email,
                // Hash and store the password securely here
                // DateRegistered = DateTime.UtcNow
            };

            var registeredUser = _userRepository.CreateUser(newUser);

            var userDto = new UserDto
            {
                UserID = registeredUser.UserID,
                Username = registeredUser.Username,
                Email = registeredUser.Email
            };

            return userDto;
        }

        public UserDto GetUserById(int userId)
        {
            var user = _userRepository.GetUserById(userId);

            var userDto = new UserDto
            {
                UserID = user.UserID,
                Username = user.Username,
                Email = user.Email
            };

            return userDto;
        }

        // Otros métodos del servicio
    }
}