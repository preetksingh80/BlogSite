using System;
using BlogSite.Entities;
using BlogSite.Logic.Tests.Security;
using Repositories;

namespace BloggingServices.Services
{
    public class UsersService : IUserService
    {
        public UsersService()
        {
            
        }
        public bool LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}