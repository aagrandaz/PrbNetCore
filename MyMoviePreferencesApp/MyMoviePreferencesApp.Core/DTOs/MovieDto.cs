
namespace MyMoviePreferencesApp.Core.DTOs
{
    public class MovieDto
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
    }
}