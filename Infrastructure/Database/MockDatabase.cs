using Domain.Models;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> Dogs
        {
            get { return allDogs; }
            set { allDogs = value; }
        }

        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Björn"},
            new Dog { Id = Guid.NewGuid(), Name = "Patrik"},
            new Dog { Id = Guid.NewGuid(), Name = "Alfred"},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests"}
        };

        // Inom Infrastruktur.Database.MockDatabase
        public bool DeleteDog(Guid dogId)
        {
            var dogToRemove = allDogs.FirstOrDefault(dog => dog.Id == dogId);

            if (dogToRemove != null)
            {
                allDogs.Remove(dogToRemove);
                return true; // Borttagningen var framgångsrik
            }

            return false; // Hunden med det angivna Id:et hittades inte
        }

    }
}
