using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Logic.Tests.Helpers
{
    public static class BlogPostTestHelper
    {
        public static BlogPost CreateBlogPost()
        {
            var authorUserId = 1;
            var title = "This is a new Article Title";
            var content = "This is the new Article Content";
            return new BlogPost(authorUserId, title, content);
        }
    }
}
