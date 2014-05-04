using BlogSite.Entities;

namespace BlogSite.Services
{
    public interface IUserService
    {
        User LoginUser(string username, string password);
    }
}