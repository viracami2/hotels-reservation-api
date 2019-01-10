using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Domain.Model.Base
{
    public abstract class ContactBase
    {
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
    }
}
