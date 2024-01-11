//using System;
//using Domain.Models.Animal;
//using Domain.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Infrastructure.Database
//{
//    public static class DatabaseSeedHelper
//    {
//        public static void SeedData(ModelBuilder modelBuilder)
//        {
//            Seed(modelBuilder);


//        }

//        private static void Seed(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Dog>().HasData(

//            new Dog { Id = Guid.NewGuid(), Name = "Björn", Breed = "shitzu", Weight = 10 },
//            new Dog { Id = Guid.NewGuid(), Name = "Patrik", Breed = "labrador", Weight = 35 },
//            new Dog { Id = Guid.NewGuid(), Name = "Alfred", Breed = "golden", Weight = 35 },
//            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests", Breed = "bulldog", Weight = 20 },
//            new Dog { Id = new Guid("87654321-4321-8765-4321-876543210987"), Name = "AnotherTestDogForUnitTests", Breed = "pitbull", Weight = 30 }
//            );

//            modelBuilder.Entity<Cat>().HasData(

//                new Cat { Id = Guid.NewGuid(), Name = "Pandis", LikesToPlay = true, Breed = "skogskatt", Weight = 5 },
//                new Cat { Id = Guid.NewGuid(), Name = "MjauMjau", LikesToPlay = false, Breed = "Mainecoon", Weight = 10 },
//                new Cat { Id = new Guid("12345678-1234-5678-1234-567812345675"), Name = "Gustaf", LikesToPlay = true, Breed = "bengal", Weight = 5 }

//            );

//            modelBuilder.Entity<Bird>().HasData(

//                new Bird { Id = Guid.NewGuid(), Name = "tweetie", CanFly = true, Color = "green" },
//                new Bird { Id = Guid.NewGuid(), Name = "chickennugget", CanFly = false, Color = "purple" },
//                 new Bird { Id = Guid.NewGuid(), Name = "fågeljävel", CanFly = true, Color = "yellow" }

//                );

//            modelBuilder.Entity<User>().HasData(

//                new User { Id = Guid.NewGuid(), Username = "Pandis", PasswordHash = "string" }

//                );


//            modelBuilder.Entity<UserAnimalModel>().HasData(

//                new UserAnimalModel { Key = Guid.NewGuid(), AnimalId = "63f78a4c-120a-4ec5-b57e-88075a7af69b", UserId = "08dc129b-5efc-4b23-8f5d-fd05308f8eae") }





//                );








//        }
//    }
//}

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
                new Dog { Id = Guid.NewGuid(), Name = "Björn", Breed = "shitzu", Weight = 10 },
                new Dog { Id = Guid.NewGuid(), Name = "Patrik", Breed = "labrador", Weight = 35 },
                new Dog { Id = Guid.NewGuid(), Name = "Alfred", Breed = "golden", Weight = 35 },
                new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests", Breed = "bulldog", Weight = 20 },
                new Dog { Id = new Guid("87654321-4321-8765-4321-876543210987"), Name = "AnotherTestDogForUnitTests", Breed = "pitbull", Weight = 30 }
            );

            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Pandis", LikesToPlay = true, Breed = "skogskatt", Weight = 5 },
                new Cat { Id = Guid.NewGuid(), Name = "MjauMjau", LikesToPlay = false, Breed = "Mainecoon", Weight = 10 },
                new Cat { Id = new Guid("12345678-1234-5678-1234-567812345675"), Name = "Gustaf", LikesToPlay = true, Breed = "bengal", Weight = 5 }
            );

            modelBuilder.Entity<Bird>().HasData(
                new Bird { Id = Guid.NewGuid(), Name = "tweetie", CanFly = true, Color = "green" },
                new Bird { Id = Guid.NewGuid(), Name = "chickennugget", CanFly = false, Color = "purple" },
                new Bird { Id = Guid.NewGuid(), Name = "fågeljävel", CanFly = true, Color = "yellow" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Username = "Pandis", PasswordHash = "string" }
            );

            modelBuilder.Entity<UserAnimalModel>().HasData(
                new UserAnimalModel { Key = Guid.NewGuid(), AnimalId = new Guid("63f78a4c-120a-4ec5-b57e-88075a7af69b"), UserId = new Guid("08dc129b-5efc-4b23-8f5d-fd05308f8eae") }
            );
        }
    }
}
