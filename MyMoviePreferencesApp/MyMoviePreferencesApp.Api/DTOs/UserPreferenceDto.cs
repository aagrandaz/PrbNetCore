using System.ComponentModel.DataAnnotations;

namespace MyMoviePreferencesApp.Api.DTOs;

public class UserPreferenceDto
{
    [Required]
    public int UserID { get; set; }
    
    [Required]
    public List<int> GenreIDs { get; set; }
}