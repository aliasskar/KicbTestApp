using Microsoft.EntityFrameworkCore;
using KicbTestApp.Models;

namespace KicbTestApp.Data 
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Делаем Email пользователя уникальным
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Делаем Номер телефона уникальным
            modelBuilder.Entity<Phone>()
                .HasIndex(p => p.PhoneNumber)
                .IsUnique();
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}