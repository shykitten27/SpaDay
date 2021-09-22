using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateJoined { get; } = DateTime.Now;

        //constructor not necessary - MVC mapping handles, add default value in DateJoined property
/*        public User()
        {
            DateJoined = DateTime.Now;
        }

        public User(string name, string username, string email, string password)
        {
            Name = name;
            Username = username;
            Email = email;
            Password = password;
            
        }*/
    }
}
