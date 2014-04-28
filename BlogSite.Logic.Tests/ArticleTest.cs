using NUnit.Framework;
using FluentAssertions;

namespace BlogSite.Logic.Tests
{
    [TestFixture]
    public class ArticleTest
    {
        [Test]
        public void CanCreateaBlogPost()
        {
            var authorUserId = 1;
            var title = "This is a new Article Title";
            var content = "This is the new Article Content";

            var blogArticle = new BlogPost(authorUserId, title, content);
            blogArticle.Should().NotBeNull();

        }
    }

    public class BlogPost
    {
        public int AuthorUserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public BlogPost(int authorUserId, string title, string content)
        {
            AuthorUserId = authorUserId;
            Title = title;
            Content = content;
        }
    }
}
