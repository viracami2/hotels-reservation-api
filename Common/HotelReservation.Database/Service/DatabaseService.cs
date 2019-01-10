using HotelReservation.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Database.Service
{
    public class DatabaseService
    {
        #region Users
        //TODO: Temporal mientras se implementa gestion de base de datos
        public List<User> Users_List()
        {
            var lstUsers = new List<User>();

            lstUsers.Add(
                new User
                {
                    Username = "dmartinez",
                    Password = "abc123$$",
                    FirstName = "Danna",
                    SecondName = null,
                    LastName = "Martinez",
                    Email = "test@yopmail.com",
                    Telefono = "6566859",
                    Celular = "+057 3045566859"
                });

            lstUsers.Add(
                new User
                {
                    Username = "sdiaz",
                    Password = "abc123$$",
                    FirstName = "Syndy",
                    SecondName = null,
                    LastName = "Diaz",
                    Email = "test@yopmail.com",
                    Telefono = "6566859",
                    Celular = "+057 3045566859"
                });

            lstUsers.Add(
                new User
                {
                    Username = "nmaru",
                    Password = "abc123$$",
                    FirstName = "Nyan",
                    SecondName = null,
                    LastName = "Maru",
                    Email = "test@yopmail.com",
                    Telefono = "6566859",
                    Celular = "+057 3045566859"
                });

            return lstUsers;
        }
        #endregion
    }
}
