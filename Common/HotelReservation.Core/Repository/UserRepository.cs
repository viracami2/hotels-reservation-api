using HotelReservation.Core.Repository.Interface;
using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Core.Utils;
using HotelReservation.Database.Service;
using HotelReservation.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                Email = user.Mail,
                Celular = user.Celular,
                Telefono = user.Telefono
            }).ToList();
        }

        public Response PostUser(User user)
        {

            try
            {
                var result = _DatabaseService.UserGet(user.Email);

                if (!string.IsNullOrEmpty(result.Mail)) throw new NullReferenceException($"[{nameof(PostUser)}] {HRConstants.ExistUser}");

                return new Response
                {
                    code = 2,
                    Content = JsonConvert.SerializeObject(result)
                };
            }
            catch (Exception e)
            {
                
                throw new HttpStatusCodeException(HttpStatusCode.BadRequest,e);
                
            }

        }
    }
}
