using Application.Commands.Dogs.UpdateDog;
using Application.Dtos;
using Infrastructure.Database;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class UpdateDogTests
    {
        private MockDatabase _mockDatabase;
        private UpdateDogByIdCommandHandler _handler;

        [SetUp]
        public void SetUp()
        {
            // Initialisera mockdatabasen och hanteraren innan varje test
            _mockDatabase = new MockDatabase();
            _handler = new UpdateDogByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidUpdate_ReturnsTrue()
        {
            // Arrange
            // Skapa en hund för att uppdatera
            var originalDogId = Guid.NewGuid();
            var originalDog = new Domain.Models.Dog { Id = originalDogId, Name = "Original Dog" };
            _mockDatabase.Dogs.Add(originalDog);

            // Skapa en uppdaterad hund
            var updatedDogDto = new DogDto { Name = "Updated Dog" };

            // Skapa en kommando för att uppdatera hunden
            var updateCommand = new UpdateDogByIdCommand(updatedDogDto, originalDogId);

            // Act
            var result = await _handler.Handle(updateCommand, CancellationToken.None);

            // Assert
            Assert.IsTrue(result, "Expected a successful update.");

            // Kontrollera om den uppdaterade hunden finns i databasen
            var updatedDog = _mockDatabase.Dogs.FirstOrDefault(dog => dog.Id == originalDogId);
            Assert.IsNotNull(updatedDog, "The updated dog should exist in the database.");

            // Kontrollera om hundens namn har uppdaterats korrekt
            Assert.AreEqual(updatedDogDto.Name, updatedDog.Name, "The dog's name should be updated.");
        }

        [Test]
        public async Task Handle_InvalidUpdate_ReturnsFalse()
        {
            // Arrange
            // Försök uppdatera en hund som inte finns i databasen
            var invalidDogId = Guid.NewGuid();
            var updatedDogDto = new DogDto { Name = "Updated Dog" };
            var updateCommand = new UpdateDogByIdCommand(updatedDogDto, invalidDogId);

            // Act
            var result = await _handler.Handle(updateCommand, CancellationToken.None);

            // Assert
            Assert.IsFalse(result, "Expected an unsuccessful update.");
        }
    }
}
