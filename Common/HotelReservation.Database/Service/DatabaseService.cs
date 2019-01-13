using HotelReservation.Database.Base;
using HotelReservation.Database.Service.Response;
using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelReservation.Database.Service
{
    public class DatabaseService : DBBase
    {
        public DatabaseService() : base()
        {
        }

        #region Users
        public IEnumerable<Users_ListResponse> Users_List()
            => Connection().Query<Users_ListResponse>(sql: "SELECT Username, Password FROM HR.Users", commandType: CommandType.Text);

        public Users_ListResponse UserGet(string mail)
            => Connection().Query<Users_ListResponse>(sql: "GetUser", parameters: new { mail }).FirstOrDefault();
        #endregion
    }
}
