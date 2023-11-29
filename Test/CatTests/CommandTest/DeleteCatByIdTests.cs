using API.Controllers.CatsController;
using Application.Commands.Cats.DeleteCat;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CatTests.CommandTest
{
    [TestFixture]
    public class DeleteCatByIdTests
    {

        private MockDatabase _mockDatabase;
        private CatsController _controller;
        private Mock<IMediator> _mediatorMock;

        [SetUp]
        public void SetUp()
        {

            _mediatorMock = new Mock<IMediator>();

            // Konfigurera IMediator att returnera null när DeleteDogCommand skickas
            _mediatorMock.Setup(m => m.Send(It.IsAny<DeleteCatByIdCommand>(), default(CancellationToken)))
             .Returns(Task.FromResult((Cat)null));
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _controller = new CatsController(_mediatorMock.Object);

        }


        [Test]
        public async Task DeleteDog_ShouldReturnNotFoundWhenDogIsDeleted()
        {
            //Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");

            //Act
            var result = await _controller.DeleteCatById(catId);

            //Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

    }
}
