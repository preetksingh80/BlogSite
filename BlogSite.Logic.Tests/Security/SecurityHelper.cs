using BlogSite.Entities;

namespace BlogSite.Logic.Tests.Security
{
    public static class SecurityHelper
    {
        public static User CreateUser()
        {
            var username = "a@a.co.uk";
            var email = "a@a";
            var firstname = "Preet";
            var lastName = "Singh";
            var password = "password";
            return new User(username, password, email,firstname, lastName);

        }
    }
}