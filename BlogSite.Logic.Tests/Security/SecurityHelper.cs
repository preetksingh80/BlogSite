using System.Collections.Generic;
using BlogSite.Entities;

namespace BlogSite.Logic.Tests.Security
{
    public static class SecurityHelper
    {
        public static User CreateUser()
        {
            var email = "a@a";
            var firstname = "Preet";
            var lastName = "Singh";
            var password = "password";
            return new User(password, email, firstname, lastName);

        }

        public static List<User> GetUserList()
        {
            return new List<User>
                {
                    new User("a", "a@a",  "asurname","a"),
                    new User("b","b@b",  "bsurnbme","b"),
                    new User("c","c@c",  "csurncme","c"),
                    new User("d","d@d",  "dsurndme","d"),
                    new User("e","e@e",  "esurneme","e"),

                };
        }
    }
}