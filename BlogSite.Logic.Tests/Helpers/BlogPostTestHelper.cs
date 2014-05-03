using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSite.Entities;

namespace BlogSite.Logic.Tests.Helpers
{
    public static class BlogPostTestHelper
    {
        public static BlogPost CreateBlogPost()
        {
            var authorUserId = 1;
            var title = "This is a new Article Title";
            var content = "This is the new Article Content";
            var post = new BlogPost(authorUserId, title);
            post.Content = content;
            return post;
        }

        public static BlogPost CreateBlogPostWithoutAuthor()
        {
            return new BlogPost(0,"title");
        }

        public static BlogPost CreateBlogPostWithoutTitle()
        {
            return new BlogPost(1, "");
        }
    }
}
