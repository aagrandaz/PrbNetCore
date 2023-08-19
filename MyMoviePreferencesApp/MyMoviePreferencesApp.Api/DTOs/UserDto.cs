using System.ComponentModel.DataAnnotations;

namespace MyMoviePreferencesApp.Api.DTOs;

public class UserDto
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
}

public class UserRegistrationDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(8)]
    public string Password { get; set; }
}
