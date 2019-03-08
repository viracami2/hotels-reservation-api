using HotelReservation.Core.Repository.Interface;
using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Core.Utils;
using HotelReservation.Database.Service;
using HotelReservation.Database.Service.Response;
using HotelReservation.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Core.Repository
{
    internal class HotelRepository : IHotelRepository
    {
        private DatabaseService dataService;

        public HotelRepository()
        {
            this.dataService = new DatabaseService();
        }

        public Hotel GetHotel(string identification)
        {
            var result = this.dataService.HotelGet(identification);

            return new Hotel
            {
                NumberIdentification =result?.NumberIdentification,
                AddressLine          =result?.AddressLine,
                HotelType            =result?.HotelType,
                Mail                 =result?.Mail
            };
        }

        public List<Hotel> GetHotels()
        {
             var result = this.dataService.Hotel_ListGet();

            return result.Select( hotel => new Hotel(JsonConvert.DeserializeObject<Hotel>(JsonConvert.SerializeObject(hotel)))
            ).ToList();            
        }

        public Response PostHotel(Hotel hotel)
        {            
            if (!string.IsNullOrEmpty(GetHotel(hotel.NumberIdentification)?.NumberIdentification))
                throw new NullReferenceException($"[{nameof(PostHotel)}] - {HRConstants.ExistHotel}");
            
            var response = this.dataService.HotelPost(JsonConvert.DeserializeObject<Hotel_Response>(JsonConvert.SerializeObject(hotel)));
            return  JsonConvert.DeserializeObject<Response>(JsonConvert.SerializeObject(response));
        }
    }
}
