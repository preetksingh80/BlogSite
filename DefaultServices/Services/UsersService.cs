using System;
using BlogSite.Entities;
using BlogSite.Services;
using Repositories.Abstractions;

namespace BloggingServices.Services
{
    public class UsersService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UsersService(IRepository<User> userRepository )
        {
            _userRepository = userRepository;
        }

        public User LoginUser(string username, string password)
        {
            var user = _userRepository.Find(usr => usr.Email == username && usr.Password == password);
            if (user == null || user.Id < 1){return new User(password, username,"", ""){LoggedIn = false, Id = 0, LastLoginDate = DateTime.Now};}
            user.LastLoginDate = DateTime.Now;
            user.LoggedIn = true;
            return user;
        }
    }
}