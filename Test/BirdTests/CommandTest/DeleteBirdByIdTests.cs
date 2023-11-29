using API.Controllers.BirdsController;
using API.Controllers.CatsController;
using Application.Commands.Birds.DeleteBird;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test.BirdTests.CommandTest
{
    [TestFixture]
    public class DeleteBirdByIdTests
    {
        private MockDatabase _mockDatabase;
        private BirdsController _controller;
        private Mock<IMediator> _mediatorMock;

        [SetUp]
        public void SetUp()
        {
            _mediatorMock = new Mock<IMediator>();

            // Konfigurera IMediator att returnera null när DeleteBirdCommand skickas
            _mediatorMock.Setup(m => m.Send(It.IsAny<DeleteBirdByIdCommand>(), default(CancellationToken)))
             .Returns(Task.FromResult((Bird)null));
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _controller = new BirdsController(_mediatorMock.Object);
        }

        [Test]
        public async Task DeleteBird_ShouldReturnNotFoundWhenBirdIsDeleted()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345678");

            // Act
            var result = await _controller.DeleteBirdById(birdId);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }
    }
}
