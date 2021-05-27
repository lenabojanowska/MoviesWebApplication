using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Data
{
    public class UsersContext: DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
           : base(options)
        {
        }

        public DbSet<UserDBO> Users { get; set; }
        public DbSet<ToplistDBO> Toplists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDBO>().ToTable("users");
            modelBuilder.Entity<ToplistDBO>().ToTable("toplists");
        }
    }
}
