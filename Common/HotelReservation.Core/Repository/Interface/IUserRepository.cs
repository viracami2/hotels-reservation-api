using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Core.Repository.Interface
{
    internal interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(string mail);
        Response PostUser(User user);
    }
}
