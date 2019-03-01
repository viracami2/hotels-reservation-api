using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Core.Repository.Service;
using HotelReservation.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Reservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        HotelService hotelService;

        public HotelController()
        {
            this.hotelService = new HotelService();
        }

        // GET: api/Hotel
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return this.hotelService.GetHotels();
        }

        // GET: api/Hotel/5
        [HttpGet("{id}", Name = "Get")]
        public Hotel Get(string id)
        {
            return this.hotelService.GetHotel(id);
        }

        // POST: api/Hotel
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Hotel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
