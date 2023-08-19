using System.ComponentModel.DataAnnotations;

namespace MyMoviePreferencesApp.Api.DTOs;

public class PreferenceDto
{
    public int PreferenceID { get; set; }
    public int UserID { get; set; }
    public int GenreIDs { get; set; }
}