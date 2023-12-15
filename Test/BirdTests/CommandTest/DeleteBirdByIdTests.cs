//using Application.Commands.Birds.DeleteBird;
//using Domain.Models;
//using Infrastructure.Database;
//using MediatR;
//using NUnit.Framework;
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Test.BirdTests.CommandTest
//{
//    [TestFixture]
//    public class DeleteBirdByIdTest
//    {
//        private DeleteBirdByIdCommandHandler _handler;
//        private MockDatabase _mockDatabase;

//        [SetUp]
//        public void Setup()
//        {
//            _mockDatabase = new MockDatabase();
//            _handler = new DeleteBirdByIdCommandHandler(_mockDatabase);
//        }

//        [Test]
//        public async Task DeleteBirdById_ShouldRemoveBirdIfExistingBirdIsDeleted()
//        {
//            // Arrange
//            var existingBirdId = new Guid("87654321-4321-8765-4321-876543210987");
//            var deleteCommand = new DeleteBirdByIdCommand(existingBirdId);

//            // Act
//            var result = await _handler.Handle(deleteCommand, new CancellationToken());

//            // Assert
//            var birdExistsAfterDeletion = _mockDatabase.Birds.Any(b => b.Id == existingBirdId);
//            Assert.IsFalse(birdExistsAfterDeletion, "Bird should be deleted from the database");
//        }
//    }
//}
