using BlogSite.Logic.Tests.Helpers;
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
            var blogPost = BlogPostTestHelper.CreateBlogPost();
            blogPost.Should().NotBeNull();

        }

        [Test]
        public void BlogPostShouldHaveAnId()
        {
            var blogpost = BlogPostTestHelper.CreateBlogPost();
            blogpost.Id.Should().BeGreaterThan(0);

        }

    }
}
