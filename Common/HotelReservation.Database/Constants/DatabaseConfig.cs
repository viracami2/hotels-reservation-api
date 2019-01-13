using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Database.Constants
{
    public static class DatabaseConfig
    {
        public static class ConnectionString
        {
            public static string Database => "Server=tcp:cv-angular.database.windows.net,1433;Initial Catalog=hotel-reservation;Persist Security Info=False;User ID=cv.angular;Password=J@P0N#21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
    }
}
