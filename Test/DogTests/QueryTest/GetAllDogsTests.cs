using Application.Queries.Dogs;
using Application.Queries.Dogs.GetAll;
using Application.Queries.Dogs.GetById;
using Domain.Models;
using Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DogTests.QueryTest
{
    [TestFixture]
    public class GetAllDogsTests
    {
        private GetAllDogsQueryHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            _mockDatabase = new MockDatabase();
            _handler = new GetAllDogsQueryHandler(_mockDatabase);

        }

        [Test]
        public async Task Test_For_Get_All_Dogs()
        {
            // Arrange
            var query = new GetAllDogsQuery();

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(List<Dog>), result);
            Assert.That(result.Count, Is.EqualTo(_mockDatabase.Dogs.Count));
        }




    }
}
