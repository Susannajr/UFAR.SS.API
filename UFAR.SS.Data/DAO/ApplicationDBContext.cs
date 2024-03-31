using Microsoft.EntityFrameworkCore;
using UFAR.SS.Data.Entities;

namespace UFAR.SS.Data.DAO
{
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<AuthorEntity> Author {  get; set; }
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
