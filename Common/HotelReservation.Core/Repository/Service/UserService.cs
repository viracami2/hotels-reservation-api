using HotelReservation.Core.Repository.Interface;
using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Core.Repository.Service
{
    public class UserService
    {
        private IUserRepository _UserRepository;

        public UserService()
        {
            this._UserRepository = new UserRepository();
        }

        public List<User> GetUsers()
        {
            return this._UserRepository.GetUsers();
        }
    }
}
