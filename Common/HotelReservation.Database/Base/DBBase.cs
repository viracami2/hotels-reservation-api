using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Insight.Database;
using HotelReservation.Database.Constants;

namespace HotelReservation.Database.Base
{
    public class DBBase
    {
        public SqlConnection Connection()
        {
            var connection = new SqlConnection(DatabaseConfig.ConnectionString.Database);
            connection.Open();

            return connection;
        }
    }
}
