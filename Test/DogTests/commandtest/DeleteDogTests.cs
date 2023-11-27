using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Database;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;
using System.Reflection.Metadata;
using API.Controllers.DogsController;
using Application.Commands.Dogs.DeleteDog;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class DeleteDogTests
    {

        private MockDatabase _mockDatabase;
        private DeleteDogCommandHandler _deleteDogCommandHandler;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _deleteDogCommandHandler = new DeleteDogCommandHandler(_mockDatabase);

        }


        [Test]
        public async Task Handle_ValidId_DeletesCorrectDog()
        {
            // Arrange
            var dogIdToDelete = new Guid("87654321-4321-8765-4321-876543210987");

            // Act
            var result = await new DeleteDogCommandHandler(_mockDatabase)
                .Handle(new DeleteDogCommand(dogIdToDelete), CancellationToken.None);

            // Assert
            Assert.IsTrue(result, "Expected a successful deletion.");

            var deletedDog = _mockDatabase.Dogs.FirstOrDefault(dog => dog.Id == dogIdToDelete);

            //kollar om hunden inte finns i db
            Assert.IsNull(deletedDog,
                "The dog should no longer exist in the database after deletion.");
        }

    }

}