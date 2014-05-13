using BlogSite.Entities;

namespace BlogSite.Services
{
    public interface IBlogpostService
    {
        void AddComment(int blogpostId, Comment comment);

    }
}