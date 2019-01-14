using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Core.Repository.Service;
using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Reservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _UserService;

        public UserController()
        {
            this._UserService = new UserService();
        }

        [HttpGet]
        public IEnumerable<HotelReservation.Domain.Model.User> Get()
        {
            return this._UserService.GetUsers();
        }

        [HttpPost]
        public Response  Post(User u )
        {
            return this._UserService.PostUser(u);
        }
    }
}
