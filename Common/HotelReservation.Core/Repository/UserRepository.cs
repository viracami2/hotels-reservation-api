using HotelReservation.Core.Repository.Interface;
using HotelReservation.Core.Repository.Service.Response;
using HotelReservation.Core.Utils;
using HotelReservation.Database.Service;
using HotelReservation.Database.Service.Response;
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

        public User GetUser(string mail)
        {
            var user = _DatabaseService.UserGet(mail);
            if (string.IsNullOrEmpty(user?.Mail)) throw new NullReferenceException($"[{nameof(GetUser)}] {HRConstants.NotExistUser}");
            var _user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(user));
            return _user;    
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
                Mail = user.Mail,
                Celular = user.Celular,
                Telefono = user.Telefono
            }).ToList();
        }
               
        public Response PostUser(User user)
        {
            try
            {
                var result = _DatabaseService.UserGet(user.Mail);
                
                if (!string.IsNullOrEmpty(result?.Mail)) throw new NullReferenceException($"[{nameof(PostUser)}] {HRConstants.ExistUser}");

                var _user= JsonConvert.DeserializeObject<Users_Response>(JsonConvert.SerializeObject(user));
                var resultt = _DatabaseService.UserPost(_user);

                return new Response
                {
                    Code = 200,
                    Content = HRConstants.CreateUserFine
                };
            }
            catch (Exception e)
            {
                throw new HttpStatusCodeException(HttpStatusCode.BadRequest,e);
            }
        }
    }
}