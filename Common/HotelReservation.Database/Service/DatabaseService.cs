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
        public IEnumerable<Users_ListResponse> Users_List()
            => Connection().Query<Users_ListResponse>(sql: "SELECT * FROM HR.Users", commandType: CommandType.Text);

        public Users_ListResponse UserGet(string mail)
            => Connection().Query<Users_ListResponse>(sql: "GetUser", parameters: new { mail }).FirstOrDefault();

        public object UserPost(Users_ListResponse usuario)
        => Connection().Query<dynamic>(sql: "PostUser", parameters: usuario).FirstOrDefault();
        #endregion
    }
}
