﻿using HotelReservation.Database.Base;
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

        public List<Hotel_Response> Hotel_ListGet()
            => Connection().Query<Hotel_Response>(sql: "GetHotels").ToList();

        public Hotel_Response HotelGet(string id)
            => Connection().Query<Hotel_Response>(sql: "GetHotel", parameters: new { id }).FirstOrDefault();

        public ResponseDB HotelPost(Hotel_Response hotel )
        {
            var output = new ResponseDB();
            var respone= Connection().Query(sql:"PostHotel",parameters: hotel,outputParameters: output);
            return output;
        }
        #endregion
    }
}
