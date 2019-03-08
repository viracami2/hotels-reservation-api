using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelReservation.Domain.Model
{
    public class Hotel
    {
        
        public Hotel(Hotel hotel)
        {            
            NumberIdentification = hotel.NumberIdentification;
            HotelType = hotel.HotelType;
            AddressLine = hotel.AddressLine;
            Mail = hotel.Mail;
            HotelName = hotel.HotelName;
        }

        public Hotel(){}

        [Required]
        public string NumberIdentification { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string HotelType { get; set; }
        [Required]
        public string AddressLine { get; set; }
        [Required]
        public string Mail { get; set; }
        

    }


} 

