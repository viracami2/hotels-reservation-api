using HotelReservation.Core.Repository.Interface;
using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Core.Repository
{
    internal class HotelRepository : IHotelRepository
    {
    

        public Hotel GetHotel(string identification)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetHotels()
        {
            throw new NotImplementedException();
        }

        public Response PostHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
