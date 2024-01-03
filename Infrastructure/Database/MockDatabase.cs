using Domain.Models;
using System.Runtime.CompilerServices;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> Dogs
        {
            get { return allDogs; }
            set { allDogs = value; }
        }

        public List<Cat> Cats
        {
            get { return allCats; }
            set { allCats = value; }
        }

        public List<Bird> Birds
        {
            get { return allBirds; }
            set { allBirds = value; }
        }

        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Björn" , Breed = "shitzu", Weight = 10},
            new Dog { Id = Guid.NewGuid(), Name = "Patrik", Breed = "labrador", Weight = 35 },
            new Dog { Id = Guid.NewGuid(), Name = "Alfred", Breed = "golden", Weight = 35 },
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests", Breed = "bulldog", Weight = 20 },
            new Dog { Id = new Guid("87654321-4321-8765-4321-876543210987"), Name = "AnotherTestDogForUnitTests", Breed = "pitbull", Weight = 30 }
        };

        private static List<Cat> allCats = new()
        {
            new Cat { Id = Guid.NewGuid(), Name = "Pandis", LikesToPlay = true, Breed = "skogskatt", Weight = 5 },
            new Cat { Id = Guid.NewGuid(), Name = "MjauMjau", LikesToPlay = false, Breed = "Mainecoon", Weight = 10 },
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345675"), Name = "Gustaf", LikesToPlay = true, Breed = "bengal", Weight = 5 }
        };

        private static List<Bird> allBirds = new()
        {
            new Bird { Id = Guid.NewGuid(), Name = "tweetie", CanFly = true, Color = "green" },
            new Bird { Id = Guid.NewGuid(), Name = "chickennugget", CanFly = false, Color = "purple" },
            new Bird { Id = Guid.NewGuid(), Name = "fågeljävel", CanFly = true, Color = "yellow" }
        };

    }
}
