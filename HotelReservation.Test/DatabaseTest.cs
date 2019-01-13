using NUnit.Framework;
using HotelReservation.Database;
using HotelReservation.Database.Service;

namespace Tests
{
    [TestFixture]
    public class DatabaseTest
    {
        [Category("Users")]
        [TestCase(TestName = "GetAllUsers")]
        public void Test1()
        {
            DatabaseService service = new DatabaseService();
            var result = service.Users_List();

            Assert.Pass();
        }

        [Category("Users")]
        [TestCase(TestName = "GetUser")]
        public void Test2()
        {
            DatabaseService service = new DatabaseService();
            var result = service.UserGet("correo1@yopmail.com");
            TestContext.WriteLine(result);
            Assert.Pass();
        }
    }
}