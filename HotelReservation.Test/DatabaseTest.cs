using NUnit.Framework;
using HotelReservation.Database;
using HotelReservation.Database.Service;

namespace Tests
{
    public class DatabaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DatabaseService service = new DatabaseService();
            var result = service.Users_List();

            Assert.Pass();
        }
    }
}