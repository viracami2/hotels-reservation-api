using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Core.Repository.Interface
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
