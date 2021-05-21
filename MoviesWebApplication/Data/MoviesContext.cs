using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data
{
    public class MoviesContext: DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDBO> Movies { get; set; }
        public DbSet<StarDBO> Stars { get; set; }
        public DbSet<RatingDBO> Ratings { get; set; }
        public DbSet<PersonDBO> People { get; set; }
        public DbSet<DirectorDBO> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDBO>().ToTable("movies");
            modelBuilder.Entity<PersonDBO>().ToTable("people");
            modelBuilder.Entity<DirectorDBO>().ToTable("directors");
            modelBuilder.Entity<StarDBO>().ToTable("stars");
            modelBuilder.Entity<RatingDBO>().ToTable("ratings");
        }
    }
}
