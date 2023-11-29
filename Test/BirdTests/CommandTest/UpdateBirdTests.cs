using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var initialBird = new Bird { Id = Guid.NewGuid(), Name = "InitialBirdName", CanFly = true };
            _mockDatabase.Birds.Add(initialBird);

            // Skapa en instans av UpdateBird
            var command = new UpdateBirdByIdCommand(updatedBird: new BirdDto { Name = "UpdatedBirdName" }, id: initialBird.Id, canFly: false);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<Bird>(result);

        }
    }
}
