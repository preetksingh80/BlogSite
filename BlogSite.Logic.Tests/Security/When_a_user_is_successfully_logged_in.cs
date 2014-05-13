using BlogSite.Entities;
using BlogSite.Services;
using BloggingServices.Services;
using FluentAssertions;
using NUnit.Framework;
using Repositories.Abstractions;

namespace BlogSite.Logic.Tests.Security
{
    [TestFixture]
    public class When_a_user_is_successfully_logged_in
    {
        protected User CurrentUser { get; set; }
        protected IUserService UserService { get; set; }
        protected IRepository<User> Repository { get; set; }

        
        public When_a_user_is_successfully_logged_in()
        {
            var username = "a@a";
            var password = "a";
            Repository = new InMemoryRepository<User>(SecurityHelper.GetUserList());
            UserService = new UsersService(Repository);
            CurrentUser = UserService.LoginUser(username, password);
        }

        [Test]
        public void User_can_create_a_blog_post()
        {
            var blogpost = new BlogPost(CurrentUser.Id, "test post");
            blogpost.AuthorUserId.Should().Be(CurrentUser.Id);
            
        }

       

        
    }
}