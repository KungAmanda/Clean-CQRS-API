using Application.Commands.Dogs.DeleteDog;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetDogByIdTests
    {
        private GetDogByIdQueryHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _handler = new GetDogByIdQueryHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");

            var query = new GetDogByIdQuery(dogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(dogId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();

            var query = new GetDogByIdQuery(invalidDogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
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

            // Check if the dog with the specified Id is no longer in the database
            Assert.IsNull(_mockDatabase.Dogs.FirstOrDefault(dog => dog.Id == dogIdToDelete),
                "The dog should no longer exist in the database after deletion.");
        }


    }
}
