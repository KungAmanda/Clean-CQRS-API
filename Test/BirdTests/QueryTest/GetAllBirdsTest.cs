//using Application.Queries.Birds.GetAll;
//using Application.Queries.Birds;
//using Domain.Models;
//using Infrastructure.Database;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Test.BirdTests.QueryTest
//{
//    [TestFixture]
//    public class GetAllBirdsTests
//    {
//        private GetAllBirdsQueryHandler _handler;
//        private MockDatabase _mockDatabase;

//        [SetUp]
//        public void SetUp()
//        {
//            _mockDatabase = new MockDatabase();
//            _handler = new GetAllBirdsQueryHandler(_mockDatabase);

//        }

//        [Test]
//        public async Task Test_For_Get_All_Birds()
//        {
//            // Arrange
//            var query = new GetAllBirdsQuery();

//            // Act
//            var result = await _handler.Handle(query, CancellationToken.None);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsInstanceOf(typeof(List<Bird>), result);
//            Assert.That(result.Count, Is.EqualTo(_mockDatabase.Birds.Count));
//        }
//    }
//}
