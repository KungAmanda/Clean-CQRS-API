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

        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Björn"},
            new Dog { Id = Guid.NewGuid(), Name = "Patrik"},
            new Dog { Id = Guid.NewGuid(), Name = "Alfred"},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests"},
            new Dog { Id = new Guid("87654321-4321-8765-4321-876543210987"), Name = "AnotherTestDogForUnitTests"}
        };

        private static List<Cat> allCats = new()
        {
            new Cat { Id = Guid.NewGuid(), Name = "Pandis"},
            new Cat { Id = Guid.NewGuid(), Name = "MjauMjau"},
            new Cat { Id = Guid.NewGuid(), Name = "Mjaosi"},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests"},
            new Cat { Id = new Guid("87654321-4321-8765-4321-876543210987"), Name = "AnotherTestDogForUnitTests"}
        };

        ////detta tar bort och return true om den lyckades annars false
        public bool DeleteDog(Guid dogId)
        {
            var dogToRemove = allDogs.FirstOrDefault(dog => dog.Id == dogId);

            if (dogToRemove != null)
            {
                allDogs.Remove(dogToRemove);
                return true;
            }

            return false;
        }

        public MockDatabase Clone()
        {
            throw new NotImplementedException();
        }
    }
}
