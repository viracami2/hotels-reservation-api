using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Domain.Model.Base
{
    public abstract class PersonBase : ContactBase
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
    }
}
