using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite
{
    public class Comment
    {
        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public BlogPost BlogPost { get; private set; }
        public User User { get; private set; }
        public Comment ParentComent { get; set; }
        public string Content { get; set; }

    }
}
