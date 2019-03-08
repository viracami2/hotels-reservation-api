using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HotelReservation.Core.Repository.Service;
using HotelReservation.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public ObjectResult Post([FromBody] Hotel hotel)
        {
         var result= this.hotelService.PostHotel(hotel);
            return StatusCode(200, result);
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
