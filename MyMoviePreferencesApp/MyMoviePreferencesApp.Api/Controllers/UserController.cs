using Microsoft.AspNetCore.Mvc;
using MyMoviePreferencesApp.Api.DTOs;

namespace MyMoviePreferencesApp.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public ActionResult<UserDto> RegisterUser(UserRegistrationDto registrationDto)
    {
        var newUser = _userService.RegisterUser(registrationDto);
        return Ok(newUser);
    }

    [HttpGet("{userId}")]
    public ActionResult<UserDto> GetUser(int userId)
    {
        var user = _userService.GetUserById(userId);
        if (user == null)
            return NotFound();

        return Ok(user);
    }
}
