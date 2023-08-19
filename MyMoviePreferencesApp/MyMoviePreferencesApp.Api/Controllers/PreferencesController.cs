using Microsoft.AspNetCore.Mvc;
using MyMoviePreferencesApp.Api.DTOs;
using MyMoviePreferencesApp.Api.Services;

namespace MyMoviePreferencesApp.Api.Controllers;

[ApiController]
[Microsoft.AspNetCore.Components.Route("api/preferences")]
public class PreferenceController : ControllerBase
{
    private readonly IPreferenceService _preferenceService;

    public PreferenceController(IPreferenceService preferenceService)
    {
        _preferenceService = preferenceService;
    }

    [HttpPost]
    public ActionResult<PreferenceDto> AddUserPreference(UserPreferenceDto userPreferenceDto)
    {
        var newPreference = _preferenceService.AddUserPreference(userPreferenceDto);
        return Ok(newPreference);
    }

    [HttpGet("{userId}")]
    public ActionResult<IEnumerable<PreferenceDto>> GetUserPreferences(int userId)
    {
        var preferences = _preferenceService.GetUserPreferences(userId);
        return Ok(preferences);
    }
}
