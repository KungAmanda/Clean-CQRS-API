using Domain.Models;
using Domain.Models.Animal;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class RealDatabase : DbContext
    {
        public RealDatabase() { }
        public RealDatabase(DbContextOptions<RealDatabase> options) : base(options) { }

        public  DbSet<Dog> Dogs { get; set; }

        public  DbSet<Cat> Cats { get; set; }

        public  DbSet<Bird> Birds { get; set; }

        public  DbSet<User> Users { get; set; }
        public DbSet<UserAnimalModel> UserAnimals { get; set; }
        public DbSet<AnimalModel> Animals { get; set; }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=Simon123!;database=RealDB",
                        new MySqlServerVersion(new Version(8, 2, 0)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Call the SeedData method from the external class
            DatabaseSeedHelper.SeedData(modelBuilder);
        }
    }

}
