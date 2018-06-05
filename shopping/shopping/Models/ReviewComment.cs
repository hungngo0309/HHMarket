using System;
namespace shopping.Models
{
    public class ReviewComment
    {

        public string CommentID { get; set; }
        public string CommentContent { get; set; }
        public string CommentDate { get; set; }
        public int Rating { get; set; }
        public ReviewComment()
        {
        }
    }
}
