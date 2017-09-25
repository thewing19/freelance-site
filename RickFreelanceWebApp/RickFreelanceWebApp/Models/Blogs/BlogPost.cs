using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RickFreelanceWebApp.Models.Blogs
{
    public class BlogPost
    {
        public int BlogPostID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public byte[] Image { get; set; }
    }
}
