namespace BlogSite.Logic.Tests.Security
{
    public interface IUserService
    {
        bool LoginUser(string username, string password);
    }
}