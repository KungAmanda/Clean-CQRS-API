﻿using System;
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
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Models;
using Moq;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class DeleteDogTests
    {

        private MockDatabase _mockDatabase;
        private DogsController _controller;
        private Mock<IMediator> _mediatorMock;

        [SetUp]
        public void SetUp()
        {

            _mediatorMock = new Mock<IMediator>();

            // Konfigurera IMediator att returnera null när DeleteDogByIdCommand skickas
            _mediatorMock.Setup(m => m.Send(It.IsAny<DeleteDogCommand>(), default(CancellationToken)))
             .Returns(Task.FromResult((Dog)null));
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _controller = new DogsController(_mediatorMock.Object);

        }


        [Test]
        public async Task DeleteDog_ShouldReturnNotFoundWhenDogIsDeleted()
        {
            //Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");

            //Act
            var result = await _controller.DeleteDog(dogId);

            //Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

    }

}