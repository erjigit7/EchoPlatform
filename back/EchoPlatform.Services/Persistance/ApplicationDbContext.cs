using EchoPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EchoPlatform.Inrastructure.Persistance
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        internal DbSet<Post> Posts { get; set; }
        internal DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(r => r.Posts)
                .WithOne(p => p.Author)
                .HasForeignKey(r => r.AuthorId);
        }
    }
}
