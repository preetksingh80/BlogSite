using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSite.Entities;
using BlogSite.Logic.Tests.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace BlogSite.Logic.Tests.Comments
{
    [TestFixture]
    public class Comment
    {
        protected BlogPost Blogpost { get; set; }
        public Comment()
        {
            Blogpost = BlogPostTestHelper.CreateBlogPost();
            Blogpost.Should().NotBeNull();
        }
        [Test]
        [ExpectedException(ExpectedMessage = "User not Signed In")]
        public void Only_signed_in_users_can_leave_a_Comment()
        {
            var nonExistingUserId = 0;
            Blogpost.Comments.Add(new Entities.Comment(Blogpost.Id, nonExistingUserId, string.Empty));
            Blogpost.Comments.Count.Should().Be(1);
        }

        [Test]
        [ExpectedException(ExpectedMessage = "Comment must be on a blogpost")]
        public void Comment_must_be_on_a_blog_post()
        {
            var notExistingPostId = 0;
            var parentCommentId = 0;
            Blogpost.Comments.Add(new Entities.Comment(notExistingPostId, Security.SecurityHelper.CreateUser().Id, string.Empty, parentCommentId));
            Blogpost.Comments.Count.Should().Be(1);
        }

        [Test]
        [ExpectedException(ExpectedMessage = "A comment on another comment must have a parent comment id")]
        public void When_commenting_on_an_existing_comment_you_must_supply_parent_comment_id()
        {
            var parentCommentId = 0;
            Blogpost.Comments.Add(new Entities.Comment(Blogpost.Id, Security.SecurityHelper.CreateUser().Id, string.Empty, parentCommentId));
            Blogpost.Comments.Count.Should().Be(1);
        }
    }
}
