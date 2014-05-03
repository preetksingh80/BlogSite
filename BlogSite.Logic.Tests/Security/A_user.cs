using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloggingServices.Services;
using NUnit.Framework;
using FluentAssertions;

namespace BlogSite.Logic.Tests.Security
{
    [TestFixture(Category = "A_user and Security Tests")]
    public class A_user
    {
        [Test]
        public void Can_be_created()
        {
            var user = SecurityHelper.CreateUser();
            user.Should().NotBeNull();
        }

        [Test]
        public void Can_log_in_using_username_and_password()
        {
            var username = "a@a";
            var password = "dummyPassword";
            IUserService userService = new UsersService();
            Boolean loggedIn = userService.LoginUser(username, password);
            loggedIn.Should().BeTrue();

        }
    }
}
