using System;
using Domain.Models.Animal;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public static class DatabaseSeedHelper
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);


        }

        private static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>().HasData(

            new Dog { Id = Guid.NewGuid(), Name = "Björn" },
            new Dog { Id = Guid.NewGuid(), Name = "Patrik" },
            new Dog { Id = Guid.NewGuid(), Name = "Alfred" },
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests" },
            new Dog { Id = new Guid("87654321-4321-8765-4321-876543210987"), Name = "AnotherTestDogForUnitTests" }
            );

            modelBuilder.Entity<Cat>().HasData(

                new Cat { Id = Guid.NewGuid(), Name = "Pandis", LikesToPlay = true },
                new Cat { Id = Guid.NewGuid(), Name = "MjauMjau", LikesToPlay = false },
                new Cat { Id = new Guid("12345678-1234-5678-1234-567812345675"), Name = "Gustaf", LikesToPlay = true }

            );

            modelBuilder.Entity<Bird>().HasData(

                new Bird { Id = Guid.NewGuid(), Name = "tweetie", CanFly = true },
                new Bird { Id = Guid.NewGuid(), Name = "chickennugget", CanFly = false }

                );

            modelBuilder.Entity<User>().HasData(

                new User { Id = Guid.NewGuid(), Username = "Pandis", PasswordHash = "string" }

                );








        }
    }
}