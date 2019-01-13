using HotelReservation.Core.Repository.Interface;
using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Database.Service;
using HotelReservation.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Core.Repository
{
    internal class UserRepository : IUserRepository
    {
        private DatabaseService _DatabaseService;

        public UserRepository()
        {
            this._DatabaseService = new DatabaseService();
        }

        public List<User> GetUsers()
        {
            var result = _DatabaseService.Users_List();

            return result.Select(user => new User
            {
                Username = user.Username,
                Password = user.Password,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                LastName = user.LastName,
                Email = user.Email,
                Celular = user.Celular,
                Telefono = user.Telefono
            }).ToList();
        }

        public Response PostUser(User user)
        {
            var result = _DatabaseService.UserGet(user.Email);

            return new Response
            {
                code = 2,
                Content = JsonConvert.SerializeObject(result.FirstOrDefault())
            };
        }
    }
}
