using System.ComponentModel.DataAnnotations;

namespace MyMoviePreferencesApp.Api.DTOs;

public class MovieDto
{
    public int MovieID { get; set; }
    public string Title { get; set; }
    public int GenreID { get; set; }
    public string Director { get; set; }
    public string Description { get; set; }
}

public class MovieCreationDto
{
    [Required]
    public string Title { get; set; }

    [Required]
    public int GenreID { get; set; }

    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public string Description { get; set; }
}
