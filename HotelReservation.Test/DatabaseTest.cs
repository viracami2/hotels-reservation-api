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
            var usuario = new Users_Response() {Username="Victor",Mail= "victor2@yopUNIQUEIDE.com", Password="abc123$$" };
            var result = service.UserPost(usuario);            
        }


        [Category("Hotels")]
        [TestCase(TestName = nameof(Should_Get_Hotel))]
        public void Should_Get_Hotel()
        {
            DatabaseService _service = new DatabaseService();
            TestContext.WriteLine(_service.HotelGet("110203")?.HotelName);
        }

        [Category("Hotels")]
        [TestCase(TestName = nameof(Should_Get_Hotels))]
        public void Should_Get_Hotels()
        {
            DatabaseService _service = new DatabaseService();
            var result= _service.Hotel_ListGet();
            TestContext.WriteLine(result[0].HotelName);
        }


        [Category("Hotels")]
        [TestCase(TestName = nameof(Should_Post_Hotel))]
        public void Should_Post_Hotel()
        {
            DatabaseService _service = new DatabaseService();
            Hotel_Response hotelTest = new Hotel_Response() { NumberIdentification="110203", HotelName="Hote el caribe", HotelType = "Corporativo",AddressLine="la boquilla",Mail="lasAmericas@yopmail.com" };
            ;
            TestContext.WriteLine(_service.HotelPost(hotelTest).Content);

        }

    }
}