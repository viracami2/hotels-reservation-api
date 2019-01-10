using HotelReservation.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Domain.Model
{
    public class User : PersonBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
