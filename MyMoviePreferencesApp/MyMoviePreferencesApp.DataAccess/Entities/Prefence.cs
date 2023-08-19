namespace MyMoviePreferencesApp.DataAccess.Entities;

public class Preference
{
    public int PreferenceID { get; set; }
    public int UserID { get; set; }
    public int GenreID { get; set; }
}