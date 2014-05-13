using BlogSite.Entities;
using BlogSite.Logic.Tests.Helpers;
using NUnit.Framework;
using FluentAssertions;

namespace BlogSite.Logic.Tests
{
    [TestFixture(Category = "Blog post tests")]
    public class When_a_blog_post_is_created
    {
        protected BlogPost Blogpost { get; set; }

        [TestFixtureSetUp]
        public void It_is_not_null()
        {
            Blogpost = BlogPostTestHelper.CreateBlogPost();
            Blogpost.Should().NotBeNull();

        }

        

        [Test]
        public void It_always_has_an_id()
        {
           Blogpost.Id.Should().BeGreaterThan(0);
        }

        [Test]
        [ExpectedException(ExpectedMessage = "Blogpost cannot be created without an author")]
        public void It_cannot_be_created_without_an_author()
        {
            var post = BlogPostTestHelper.CreateBlogPostWithoutAuthor();
            
        }

        [Test]
        [ExpectedException(ExpectedMessage = "Blogpost cannot be created without a title")]
        public void It_cannot_be_created_without_a_title()
        {
            var post = BlogPostTestHelper.CreateBlogPostWithoutTitle();

        }

        [Test]
        public void It_has_comments()
        {
            Blogpost.Comments.Should().NotBeNull();
        }

       
       

       


    }
}
