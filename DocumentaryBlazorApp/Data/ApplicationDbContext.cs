using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DocumentaryBlazorApp.Models;

namespace DocumentaryBlazorApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Documentary> Documentaries { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>()
                .HasOne<Documentary>()
                .WithMany(d => d.Reviews)
                .HasForeignKey(r => r.DocumentaryId);

            SampleData.AddSampleRecords(modelBuilder);
        }
    }
}