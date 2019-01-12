using HotelReservation.Core.Repository.Interface;
using HotelReservation.Database.Service;
using HotelReservation.Domain.Model;
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
    }
}
