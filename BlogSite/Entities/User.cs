using System;
using BlogSite.Entities.Abstractions;

namespace BlogSite.Entities
{
    public class User : IEntity
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public DateTime LastLoginDate { get; set; }

        public bool LoggedIn { get; set; }

        public User(string password, string email, string firstname, string lastName)
        {
            Id = 1;
            Password = password;
            Email = email;
            Firstname = firstname;
            LastName = lastName;
        }

        
    }
}
