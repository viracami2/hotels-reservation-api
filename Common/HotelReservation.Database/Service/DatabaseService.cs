using HotelReservation.Database.Base;
using HotelReservation.Database.Service.Response;
using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace HotelReservation.Database.Service
{
    public class DatabaseService : DBBase
    {
        public DatabaseService() : base()
        {
        }

        #region Users
        public IEnumerable<Users_Response> Users_List()
            => Connection().Query<Users_Response>(sql: "SELECT * FROM HR.Users", commandType: CommandType.Text);

        public Users_Response UserGet(string mail)
            => Connection().Query<Users_Response>(sql: "GetUser", parameters: new { mail }).FirstOrDefault();

        public object UserPost(Users_Response usuario)
        => Connection().Query<dynamic>(sql: "PostUser", parameters: usuario).FirstOrDefault();
        #endregion



        #region Hoteles

        public Hotel_Response HotelGet(string id)
            => Connection().Query<Hotel_Response>(sql: "GetHotel", parameters: new { id }).FirstOrDefault();

        public object HotelPost(Hotel_Response hotel )
            => Connection().Query<Hotel_Response>(sql:"PostHotel",parameters: hotel);
        #endregion
    }
}
