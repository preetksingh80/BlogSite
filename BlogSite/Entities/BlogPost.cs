using System;
using System.Collections.Generic;

namespace BlogSite.Entities
{
    public class BlogPost
    {
        public int AuthorUserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get;  set; }
        public DateTime CreatedDate { get;  set; }
        public DateTime UpdatedDate { get; set; }
        public IList<string> Tags { get; set; }
        public IList<Comment> Comments { get; set; }

        public BlogPost(int authorUserId, string title)
        {
            if (authorUserId < 1 ){throw new ApplicationException("Blogpost cannot be created without an author");}
            if (string.IsNullOrWhiteSpace(title)) { throw new ApplicationException("Blogpost cannot be created without a title"); }
            Id = 1;
            AuthorUserId = authorUserId;
            Title = title;
            Content = string.Empty;
            Tags = new List<string>();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Comments = new List<Comment>();
        }

        
    }
}