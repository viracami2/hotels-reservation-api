using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Domain.Model;
using System.Collections.Generic;

namespace HotelReservation.Core.Repository.Interface
{
    internal interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(string mail);
        Response PostUser(User user);
    }
}
