using System;

namespace BlogSite.Entities
{
    public class Comment
    {
        public int Id { get;  set; }
        public DateTime CreatedDate { get;  set; }
        public int BlogPostId { get;  set; }
        public int UserId { get;  set; }
        public int ParentComentId { get;  set; }
        public string Content { get;  set; }
        public int ParentCommentId { get; set; }

        public Comment(int blogPostId, int userId, string content)
        {
            if(userId < 1 ) throw  new ApplicationException("User not Signed In");
            if (blogPostId < 1) throw new ApplicationException("Comment must be on a blogpost");
            UserId = userId;
            BlogPostId = blogPostId;
            Id = 0;
            CreatedDate = DateTime.Now;
            ParentComentId = 0;
            Content = content;

        }

        public Comment(int blogPostId, int userId, string content, int parentCommentId):this(blogPostId,userId,content)
        {
            if(parentCommentId < 1) throw new ApplicationException("A comment on another comment must have a parent comment id");
            ParentCommentId = parentCommentId;
        }
    }
}
