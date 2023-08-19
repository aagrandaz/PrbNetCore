using MyMoviePreferencesApp.DataAccess.Entities;

namespace MyMoviePreferencesApp.DataAccess;

using Microsoft.EntityFrameworkCore;

namespace MyMoviePreferencesApp.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Preference> Preferences { get; set; }
    }
}