using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Models;

namespace start.Managers
{
    public class UserLogic
    {
        public static List<User> UserTable = new List<User>()
        {
            new User(1, "admin@gmail.com", 1234, "SuperAdmin")
        };
        public User Login(string email, int pin)
        {
            var user = UserTable.Find(a => a.Email == email && a.Pin == pin);
            return user;
        }
    }
}