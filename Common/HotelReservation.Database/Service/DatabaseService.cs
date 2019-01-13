using HotelReservation.Database.Base;
using HotelReservation.Database.Service.Response;
using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
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
            => Connection().Query<Users_ListResponse>("SELECT Username, Password FROM HR.Users", null, CommandType.Text);

        public IList<Users_ListResponse> UserGet(string mail)
            => Connection().Query<Users_ListResponse>("dbo.GetUser", new { mail = mail });
        #endregion
    }
}
