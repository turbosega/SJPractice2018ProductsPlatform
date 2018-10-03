using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DatabaseSeed
    {
        public static void Seed(StoreContext _storeContext)
        {
            _storeContext.Database.Migrate();

            List<User> users = new List<User>
            {
                new User { 
                    UserId = 1, 
                    Email = "somemail@smth.com", 
                    Password = "123", 
                    Salt = "456", 
                    RegisteredAt = new DateTime(2007, 10, 23),
                    RoleId = 1
                },
                new User {
                    UserId = 2,
                    Email = "someOther@smth.com",
                    Password = "0923",
                    Salt = "ejkfs",
                    RegisteredAt = new DateTime(2008, 11, 25),
                    RoleId = 1
                }
            };

            if (!_storeContext.Users.Any())
            {
                foreach (var user in users)
                {
                    _storeContext.Users.Add(user);
                    _storeContext.SaveChanges();
                }
            }
        }
    }
}