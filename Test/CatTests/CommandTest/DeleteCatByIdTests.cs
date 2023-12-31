﻿//using Application.Commands.Cats.DeleteCat;
//using Infrastructure.Database;

//namespace Test.CatTests.CommandTest
//{
//    [TestFixture]
//    public class DeleteCatByIdTest
//    {
//        private DeleteCatByIdCommandHandler _handler;
//        private MockDatabase _mockDatabase;

//        [SetUp]
//        public void Setup()
//        {
//            _mockDatabase = new MockDatabase();
//            _handler = new DeleteCatByIdCommandHandler(_mockDatabase);
//        }

//        [Test]
//        public async Task DeleteCatById_ShouldRemoveCatIfExistingCatIsDeleted()
//        {
//            // Arrange
//            var existingCatId = new Guid("87654321-4321-8765-4321-876543210987");
//            var deleteCommand = new DeleteCatByIdCommand(existingCatId);

//            // Act
//            var result = await _handler.Handle(deleteCommand, new CancellationToken());

//            // Assert
//            var catExistsAfterDeletion = _mockDatabase.Cats.Any(c => c.Id == existingCatId);
//            Assert.IsFalse(catExistsAfterDeletion, "Cat should be deleted from the database");
//        }
//    }
//}
