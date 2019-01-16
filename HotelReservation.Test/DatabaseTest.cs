using NUnit.Framework;
using HotelReservation.Database.Service;
using HotelReservation.Database.Service.Response;
using Newtonsoft.Json.Linq;

namespace Tests
{
    [TestFixture]
    public class DatabaseTest
    {
        [Category("Users")]
        [TestCase(TestName = "Should_Get_All_User")]
        public void Test1()
        {
            DatabaseService service = new DatabaseService();
            var result = service.Users_List();
            TestContext.WriteLine(result);
        }

        [Category("Users")]
        [TestCase(TestName = "Should_Get_User")]
        public void Test2()
        {
            DatabaseService service = new DatabaseService();
            var result = service.UserGet("correo1@yopmail.com");
            TestContext.WriteLine(result);
        }
        
        [Category("Users")]
        [TestCase(TestName = "Should_Create_User")]
        public void Test3()
        {
            DatabaseService service = new DatabaseService();
            var usuario = new Users_ListResponse() {Username="Victor",Mail= "victor2@yopmaUNIQUEIDE.com", Password="abc123$$" };
            var result = service.UserPost(usuario);            
        }
    }
}