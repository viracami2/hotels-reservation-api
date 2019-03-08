using HotelReservation.Core.Repository.Interface;
using HotelReservation.Domain.Model;
using System.Collections.Generic;

namespace HotelReservation.Core.Repository.Service
{
    public class HotelService
    {

        private IHotelRepository hotelRepository;

        public HotelService()
        {
            this.hotelRepository =new HotelRepository();
        }


        public Hotel GetHotel(string id)
        {
            return hotelRepository.GetHotel(identification : id);
        }

        public List<Hotel> GetHotels()
        {
            return hotelRepository.GetHotels();
        }

        public Response.Response PostHotel(Hotel hotel)
        {
            return this.hotelRepository.PostHotel(hotel);
            
        }
    }
}
