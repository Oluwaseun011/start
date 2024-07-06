using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace start.Models
{
    public class User
    {
        public int Id;
        public string Email;
        public int Pin;
        public string Role;

        public User(int id, string email, int pin, string role)
        {
            Id = id;
            Email = email;
            Pin = pin;
            Role = role;
        }
    }
}