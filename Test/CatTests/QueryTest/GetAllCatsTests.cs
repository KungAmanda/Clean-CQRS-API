//using Application.Queries.Cats.GetAll;
//using Application.Queries.Cats;
//using Domain.Models;
//using Infrastructure.Database;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Test.CatTests.QueryTest
//{
//    [TestFixture]
//    public class GetAllCatsTests
//    {
//        private GetAllCatsQueryHandler _handler;
//        private MockDatabase _mockDatabase;

//        [SetUp]
//        public void SetUp()
//        {
//            _mockDatabase = new MockDatabase();
//            _handler = new GetAllCatsQueryHandler(_mockDatabase);

//        }

//        [Test]
//        public async Task Test_For_Get_All_Cats()
//        {
//            // Arrange
//            var query = new GetAllCatsQuery();

//            // Act
//            var result = await _handler.Handle(query, CancellationToken.None);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsInstanceOf(typeof(List<Cat>), result);
//            Assert.That(result.Count, Is.EqualTo(_mockDatabase.Cats.Count));
//        }




//    }
//}
