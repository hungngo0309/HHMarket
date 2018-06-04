using System;
namespace shopping.Models
{
    public class ReviewComment
    {

        public String CommentID { get; set; }
        public String CommentContent { get; set; }
        public String CommentDate { get; set; }
        public int Rating { get; set; }
        public ReviewComment()
        {
        }
    }
}
