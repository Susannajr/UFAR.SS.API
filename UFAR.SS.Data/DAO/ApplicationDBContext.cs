using Microsoft.EntityFrameworkCore;
using UFAR_SS_Data.Entities;

namespace UFAR_SS_Data.DAO
{
    /// <summary>
    /// This class represents the application database context. 
    /// Constructor for the 'ApplicationDBContext' class.
    /// </summary>
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
    {
        // Represents a DbSet for ItemEntity objects in the database.
        public DbSet<ItemEntity> Items { get; set; }
        // Represents a DbSet for AuthorEntity objects in the database.
        public DbSet<AuthorEntity> Author {  get; set; }
        // Represents a DbSet for StyleEntity objects in the database.
        public DbSet<StyleEntity> Styles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorEntity>()
            .HasKey(c => c.Id);

            modelBuilder.Entity<ItemEntity>()
          .HasKey(c => c.Id);

            modelBuilder.Entity<StyleEntity>()
          .HasKey(c => c.Id);
        }
    }
}
