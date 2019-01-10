using HotelReservation.Core.Repository.Interface;
using HotelReservation.Database.Service;
using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
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
            return _DatabaseService.Users_List();
        }
    }
}
