using System;
using System.Collections.Generic;

namespace BlogSite
{
    public class BlogPost
    {
        public int AuthorUserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; set; }
        public IList<string> Tags { get; private set; }
        
        public BlogPost(int authorUserId, string title, string content)
        {
            AssignId();
            AuthorUserId = authorUserId;
            Title = title;
            Content = content;
            Tags = new List<string>();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        private void AssignId()
        {
            Id = 1;
        }
    }
}