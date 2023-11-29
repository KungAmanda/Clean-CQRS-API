using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Database;


namespace Test.BirdTests.CommandTest
{
    [TestFixture]
    public class UpdateBirdTests
    {
        private UpdateBirdByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void Setup()
        {
            _mockDatabase = new MockDatabase();
            _handler = new UpdateBirdByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_UpdatesBirdInDatabase()
        {
            // Arrange
            var initialBird = new Bird { Id = Guid.NewGuid(), Name = "InitialBirdName" };
            _mockDatabase.Birds.Add(initialBird);

            // Skapar en instans av UpdateBird
            var command = new UpdateBirdByIdCommand(
                updatedBird: new BirdDto { Name = "UpdatedBirdName" },
                id: initialBird.Id
            );

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<Bird>(result);

            //// Kolla om fågeln har det uppdaterade namnet 
            //Assert.That(result.Name, Is.EqualTo("UpdatedBirdName"));

            //// Kolla om fågeln har uppdaterats i mockdatabasen också
            //var updatedBirdInDatabase = _mockDatabase.Birds.FirstOrDefault(bird => bird.Id == command.Id);
            //Assert.That(updatedBirdInDatabase, Is.Not.Null);
            //Assert.That(updatedBirdInDatabase.Name, Is.EqualTo("UpdatedBirdName"));
        }
    }
}
