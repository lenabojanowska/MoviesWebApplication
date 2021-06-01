using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data.DBO;

namespace MoviesWebApplication.Data
{
    public class UsersContext: DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
           : base(options)
        {
        }

        public DbSet<ToplistDBO> Toplists { get; set; }
        public DbSet<ToplistMoviesDBO> ToplistMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToplistDBO>().ToTable("toplists");
            modelBuilder.Entity<ToplistMoviesDBO>().ToTable("movies");
        }
    }
}
