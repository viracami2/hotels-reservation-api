using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Core.Repository.Interface
{
    internal interface IHotelRepository
    {
        List<Hotel> GetHotels();
        Hotel GetHotel(string identification);
        Response PostHotel(Hotel hotel);
    }
}
