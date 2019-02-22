namespace HotelReservation.Database.Service.Response
{
    public class Users_ListResponse
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }                
    }
}
