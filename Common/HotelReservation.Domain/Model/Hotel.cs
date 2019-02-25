using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelReservation.Domain.Model
{
    public class Hotel
    {
        
        [Required]
        public string NumberIdentification { get; set; }
        [Required]
        public string HotelType { get; set; }
        [Required]
        public string AddressLine { get; set; }
        [Required]
        public string Mail { get; set; }
        

    }


} 

