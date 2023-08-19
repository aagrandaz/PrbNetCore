using MyMoviePreferencesApp.DataAccess.Entities;
using MyMoviePreferencesApp.DataAccess.MyMoviePreferencesApp.DataAccess;

namespace MyMoviePreferencesApp.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User CreateUser(UserRegistrationDto registrationDto)
    {
        var newUser = new User
        {
            Username = registrationDto.Username,
            Email = registrationDto.Email,
            // Hash and store the password securely here
            // DateRegistered = DateTime.UtcNow
        };

        _dbContext.Users.Add(newUser);
        _dbContext.SaveChanges();

        return newUser;
    }

    public User GetUserById(int userId)
    {
        return _dbContext.Users.FirstOrDefault(u => u.UserID == userId);
    }
}